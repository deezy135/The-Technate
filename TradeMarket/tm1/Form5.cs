﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace tm1 {
	public partial class SellItemForm : Form {

		private MySqlConnection Con;
		private string ConString;
		UInt32 ItemID;
		UInt32 UserID;
		ItemForm ItemForm;
		public SellItemForm(UInt32 itemID, UInt32 userID, ItemForm itemForm) {
			InitializeComponent();
			ItemID = itemID;
			UserID = userID;
			ItemForm = itemForm;
			ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			Con = new MySqlConnection(ConString);
		}
		private bool OpenCon() {
			try {
				Con.Open();
				return true;
			}
			catch (MySqlException ex) {
				switch (ex.Number) {
					case 0:
						MessageBox.Show("Cannot connect to server.  Contact administrator");
						break;
					case 1045:
						MessageBox.Show("Invalid username/password, please try again");
						break;
				}
				return false;
			}
		}

		private bool CloseCon() {
			try {
				Con.Close();
				return true;
			}
			catch (MySqlException ex) {
				MessageBox.Show(ex.Message);
				return false;
			}
		}

		private void SellRequestButton_Click(object sender, EventArgs e) {
			if (PriceTextBox.Text == "") {
				MessageBox.Show("Введите цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (QuantityTextBox.Text == "") {
				MessageBox.Show("Введите количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (OpenCon()) {
				UInt32 quantity = 0;
				UInt32 price = 0;
				bool success = true;
				try {
					quantity = Convert.ToUInt32(QuantityTextBox.Text);
					price = Convert.ToUInt32(PriceTextBox.Text);
				}
				catch (Exception) {
					MessageBox.Show("Неправильное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					success = false;
				}
				if (success) {
					string queueQuan = "CALL checkQuantity('" + UserID.ToString()
						+ "', '" + ItemID.ToString() + "', '" + quantity.ToString() + "', @quan); "
						+ "SELECT @quan";
					MySqlCommand cmdQuan = new MySqlCommand(queueQuan, Con);
					if (Convert.ToInt32(cmdQuan.ExecuteScalar()) == 1) {
						string queueRequest = "CALL createSellRequest('" + UserID.ToString()
							+ "', '" + ItemID.ToString() + "', '" + quantity.ToString()
							+ "', '" + price.ToString() + "'); "
							+ "CALL getItem('" + UserID.ToString() + "', '" + ItemID.ToString()
							+ "', '" + quantity.ToString() + "')";
						MySqlCommand cmdRequest = new MySqlCommand(queueRequest, Con);
						try {
							cmdRequest.ExecuteNonQuery();
						}
						catch(MySqlException ex) {
							MessageBox.Show("Произошла ошибка при выполнении транзакции.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
							success = false;
						}
					}
					else {
						MessageBox.Show("Недостаточно предметов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						success = false;
					}
					if (success) {
						MessageBox.Show("Предмет выставлен на продажу");
					}
				}
				CloseCon();
				if (success) {
					Close();
				}
			}
		}

		private void SellItemForm_FormClosed(object sender, FormClosedEventArgs e) {
			ItemForm.RefreshForm();
		}
	}
}
