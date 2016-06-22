using System;
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
    public partial class MainForm : Form {
        LoginForm loginForm;
		UInt32 UserID;
		private MySqlConnection Con;
		private string ConString;
		public MainForm() {
            InitializeComponent();
			loginForm = new LoginForm(this);
			loginForm.ShowDialog();
			UserID = loginForm.UserID;
			ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			Con = new MySqlConnection(ConString);
			RefreshForm();
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

		public void RefreshForm() {
			if (OpenCon()) {
				string query = "SELECT name, money, image FROM users WHERE id_user='" + UserID.ToString() + "'";
				MySqlCommand cmd = new MySqlCommand(query, Con);
				MySqlDataReader reader = cmd.ExecuteReader();
				reader.Read();
				UserNameLabel.Text = reader["name"].ToString();
				UserDescriptionTextBox.Text = "Баланс: " + reader["money"].ToString();
				UserPictureBox.ImageLocation = reader["image"].ToString();

				//SearchItemTextBox.Clear();
				//SearchTraderTextBox.Clear();
				//SearchInventoryItemTextBox.Clear();
				CloseCon();
			}
			SearchItemButton.PerformClick();
			SearchTraderButton.PerformClick();
			SearchInventoryButton.PerformClick();
		}
		

        private void SearchItemButton_Click(object sender, EventArgs e) {
			if (OpenCon()) {
				string query = "SELECT id_item, image, name FROM items WHERE name LIKE '%" + SearchItemTextBox.Text + "%'";
				MySqlDataAdapter msda = new MySqlDataAdapter(query, Con);
				DataSet ds = new DataSet();
				msda.Fill(ds);
				SearchItemData.Rows.Clear();
				foreach (DataRow row in ds.Tables[0].Rows) {
					string querySum = "SELECT SUM(quantity) as sum, MIN(price) as price FROM itemstosell WHERE "
						+ "id_item='" + row["id_item"] + "'";
					MySqlCommand cmdSum = new MySqlCommand(querySum, Con);
					MySqlDataReader reader = cmdSum.ExecuteReader();
					reader.Read();
					object[] values = {
						row["id_item"], Image.FromFile(row["image"].ToString()),
						row["name"], reader["sum"], reader["price"]//sumds.Tables[0].Rows[0][0], sumds.Tables[0].Rows[0][1]
					};
					SearchItemData.Rows.Add(values);
					reader.Dispose();
					cmdSum.Dispose();
				}
				CloseCon();
			}
		}

        private void SearchTradersData_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			if (e.ColumnIndex == 2) {
				UInt32 traderID = Convert.ToUInt32(SearchTraderData.Rows[e.RowIndex].Cells[0].Value);
				TraderForm traderForm = new TraderForm(traderID);
				traderForm.Show();
			}
        }

        private void SearchItemData_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 2) {
                UInt32 itemID = Convert.ToUInt32(SearchItemData.Rows[e.RowIndex].Cells[0].Value);
                ItemForm itemForm = new ItemForm(UserID, itemID);
                itemForm.Show();
            }
        }

		private void SearchInventoryData_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			if (e.ColumnIndex == 2) {
				UInt32 itemID = Convert.ToUInt32(SearchInventoryData.Rows[e.RowIndex].Cells[0].Value);
				ItemForm itemForm = new ItemForm(UserID, itemID);
				itemForm.Show();
			}
		}
		private void SearchTraderButton_Click(object sender, EventArgs e) {
			if (OpenCon()) {
				string query = "SELECT id_user, image, name, money FROM users WHERE name LIKE '%" + SearchTraderTextBox.Text + "%'";
				MySqlDataAdapter msda = new MySqlDataAdapter(query, Con);
				DataSet ds = new DataSet();
				msda.Fill(ds);
				SearchTraderData.Rows.Clear();
				foreach (DataRow row in ds.Tables[0].Rows) {
					string queryTradesNumber = "SELECT COUNT(*) FROM trades "
						+ "WHERE (id_buyer='" + row["id_user"] + "' "
						+ "OR id_seller='" + row["id_user"] + "')";
					MySqlCommand cmdTradesNumber = new MySqlCommand(queryTradesNumber, Con);
					UInt32 tradesNumber = Convert.ToUInt32(cmdTradesNumber.ExecuteScalar());
					object[] values = {
						row["id_user"], Image.FromFile(row["image"].ToString()),
						Convert.ToString(row["name"]), tradesNumber, row["money"]
					};
					SearchTraderData.Rows.Add(values);
				}
				CloseCon();
			}
        }

        private void SearchInventoryButton_Click(object sender, EventArgs e) {
			if (OpenCon()) {
				string query = "SELECT items.id_item, image, name, quantity "
					+ "FROM items, users_items WHERE items.id_item=users_items.id_item "
					+ "AND id_user='" + UserID.ToString() + "' "
					+ "AND name LIKE '%" + SearchInventoryItemTextBox.Text + "%'";
				MySqlDataAdapter msda = new MySqlDataAdapter(query, Con);
				DataSet ds = new DataSet();
				msda.Fill(ds);
				SearchInventoryData.Rows.Clear();
				foreach (DataRow row in ds.Tables[0].Rows) {
					object[] values = {
						row["id_item"], Image.FromFile(row["image"].ToString()),
						row["name"], row["quantity"]
					};
					SearchInventoryData.Rows.Add(values);
				}
				CloseCon();
			}
        }

		private void SearchItemTextBox_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				SearchItemButton.PerformClick();
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}

		private void SearchTraderTextBox_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				SearchTraderButton.PerformClick();
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.F5) {
				RefreshForm();
			}
		}

		/*private void InventoryItemSellButton_Click(object sender, EventArgs e) {
			string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			MySqlConnection con = new MySqlConnection(ConString);
			string CmdString = "SELECT money FROM users WHERE id_user='" + UserID.ToString() + "'";
			MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, con);
			DataSet ds = new DataSet();
			sda.Fill(ds);
			UInt32 total = 0;
			bool allPrices = true;
			UInt32 index = 0;
			try {
				foreach (DataGridViewRow row in SearchInventoryData.Rows) {
					index++;
					if (Convert.ToBoolean(row.Cells[4].Value)) {
						if (Convert.ToUInt32(row.Cells[5].Value) > Convert.ToUInt32(row.Cells[3].Value)) {
							throw new FormatException();
						}

						if (Convert.ToUInt32(row.Cells[6].Value) == 0) {
							allPrices = false;
						}
						total++;
					}
				}
			}
			catch (FormatException) {
				MessageBox.Show("Неправильное значение в строке " + index.ToString());
				return;
			}
			if (total == 0) {
				MessageBox.Show("Предметы не выбраны");
				return;
			}
			if (!allPrices) {
				MessageBox.Show("Не выбрана цена");
				return;
			}
			con.Open();
			foreach (DataGridViewRow row in SearchInventoryData.Rows) {
				if (Convert.ToBoolean(row.Cells[4].Value)) {
					string addSellRequest = "INSERT INTO itemstosell (id_item, id_seller, quantity, "
					+ "price) VALUES ('" + row.Cells["InventoryItemID"].Value.ToString() + "', '"
					+ UserID.ToString() + "', '" + row.Cells["InventoryItemSellQuantity"].Value.ToString()
					+ "', '" + row.Cells["InventoryItemSellPrice"].Value.ToString() + "')";
					MySqlCommand addSellRequestCmd = new MySqlCommand(addSellRequest, con);
					try {
						addSellRequestCmd.ExecuteNonQuery();
					}
					catch (Exception) {
						MessageBox.Show("Произошла ошибка при добавлении записи в таблицу продаж");
						break;
					}

					string getItems = "CALL getItem('" + UserID.ToString() + "', '"
						+ row.Cells["InventoryItemID"].Value.ToString() + "', '"
						+ row.Cells["InventoryItemSellQuantity"].Value.ToString() + "')";
					MySqlCommand getItemsCmd = new MySqlCommand(getItems, con);
					try {
						getItemsCmd.ExecuteNonQuery();
					}
					catch (Exception) {
						MessageBox.Show("Произошла ошибка при взятии предмета из инвентаря");
						break;
					}
				}
			}
			con.Close();
		}*/
	}
}
