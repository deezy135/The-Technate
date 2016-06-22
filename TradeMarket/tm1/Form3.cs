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
	public partial class ItemForm : Form {
		UInt32 ItemID;
		UInt32 UserID;
		private MySqlConnection Con;
		private string ConString;
		public ItemForm(UInt32 userID, UInt32 itemID) {
			InitializeComponent();
			ItemID = itemID;
			UserID = userID;

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

		private void RefreshSells() {
			if (OpenCon()) {
				SellOffersData.Rows.Clear();
				string query = "SELECT id_request, id_seller, name, quantity, price "
					+ "FROM itemstosell, users "
					+ "WHERE id_item='" + ItemID.ToString() + "' and id_seller=id_user ORDER BY price";
				MySqlDataAdapter msda = new MySqlDataAdapter(query, Con);
				DataSet ds = new DataSet();
				msda.Fill(ds);
				foreach (DataRow row in ds.Tables[0].Rows) {
					object[] values = {
						row["id_request"], ItemID, row["name"], row["quantity"], row["price"], false, row["quantity"]
					};
					SellOffersData.Rows.Add(values);
				}
				CloseCon();
			}
		}

		private void RefreshBuys() {
			if (OpenCon()) {
				BuyOffersData.Rows.Clear();
				string query = "SELECT id_request, id_buyer, name, quantity, price "
					+ "FROM itemstobuy, users "
					+ "WHERE id_item='" + ItemID.ToString() + "' and id_buyer=id_user ORDER BY price DESC";

				MySqlDataAdapter msda = new MySqlDataAdapter(query, Con);
				DataSet ds = new DataSet();
				msda.Fill(ds);
				foreach (DataRow row in ds.Tables[0].Rows) {
					object[] values = {
						row["id_request"], ItemID, row["name"], row["quantity"], row["price"], false, row["quantity"]
					};
					BuyOffersData.Rows.Add(values);
				}
				CloseCon();
			}
		}

		private void RefreshTrades() {
			if (OpenCon()) {
				TradesData.Rows.Clear();
				string query = "SELECT id_seller, id_buyer, s.name as sname, b.name as bname, quantity, price, date "
					+ "FROM trades, users as s, users as b "
					+ "WHERE id_item='" + ItemID.ToString() + "' and "
					+ "id_seller=s.id_user and id_buyer=b.id_user ORDER BY date DESC";
				MySqlDataAdapter msda = new MySqlDataAdapter(query, Con);
				DataSet ds = new DataSet();
				msda.Fill(ds);
				foreach (DataRow row in ds.Tables[0].Rows) {
					object[] values = {
						row["id_seller"], row["id_buyer"], row["sname"], row["bname"],
						row["quantity"], row["price"], row["date"]
					};
					TradesData.Rows.Add(values);
				}
				CloseCon();
			}
		}

		private void RefreshInfo() {
			if (OpenCon()) {
				string query = "SELECT * FROM items WHERE id_item='" + ItemID.ToString() + "'";

				MySqlDataAdapter msda = new MySqlDataAdapter(query, Con);
				DataSet ds = new DataSet();
				msda.Fill(ds);

				ItemImage.ImageLocation = ds.Tables[0].Rows[0]["image"].ToString();
				ItemNameLabel.Text = ds.Tables[0].Rows[0]["name"].ToString();
				ItemDescriptionTextBox.Text = ds.Tables[0].Rows[0]["description"].ToString();

				string queryTags = "SELECT id_item, tags.name "
					+ "FROM items_tags, tags "
					+ "WHERE id_item='" + ItemID.ToString() + "' and tags.id_tag=items_tags.id_tag";

				MySqlDataAdapter msdaTags = new MySqlDataAdapter(queryTags, Con);
				DataSet dsTags = new DataSet();
				msdaTags.Fill(dsTags);
				ItemDescriptionTextBox.Text = "";

				foreach (DataRow row in dsTags.Tables[0].Rows) {
					ItemDescriptionTextBox.Text += row["name"].ToString() + " ";
				}
				CloseCon();
			}
		}

		public void RefreshForm() {
			RefreshInfo();
			RefreshSells();
			RefreshBuys();
			RefreshTrades();
		}

		private bool CheckBuyData() {
			UInt32 totalPrice = 0;
			UInt32 index = 0;
			try {
				foreach (DataGridViewRow row in SellOffersData.Rows) {
					index++;
					if (Convert.ToBoolean(row.Cells["BuyCheck"].Value)) {
						if (Convert.ToUInt32(row.Cells["BuyQuantity"].Value) > 
							Convert.ToUInt32(row.Cells["SellItemQuantity"].Value)) {
							throw new ArgumentOutOfRangeException();
						}
						totalPrice += Convert.ToUInt32(row.Cells["SellItemPrice"].Value) *
							Convert.ToUInt32(row.Cells["BuyQuantity"].Value);
					}
				}
			}
			catch (ArgumentOutOfRangeException) {
				MessageBox.Show("Выбрано слишком большое значение в строке " + index.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			catch (Exception) {
				MessageBox.Show("Неправильное значение в строке " + index.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (totalPrice == 0) {
				MessageBox.Show("Предметы не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
		
		private bool ConfirmBuy() {
			DialogResult dialogResult = MessageBox.Show("Приобрести предметы?", "Подтверждение", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes) {
				return true;
			}
			return false;
		}

		private void BuyButton_Click(object sender, EventArgs e) {
			if (OpenCon()) {
				/*string queryMoney = "SELECT money FROM users WHERE id_user='" + UserID.ToString() + "'";
				MySqlDataAdapter msdaMoney = new MySqlDataAdapter(queryMoney, Con);
				DataSet dsMoney = new DataSet();
				msdaMoney.Fill(dsMoney);*/
				if (CheckBuyData() && ConfirmBuy()) { 
				//if (CheckBuyData(Convert.ToUInt32(dsMoney.Tables[0].Rows[0]["money"])) && ConfirmBuy()) {
					int successfulTrades = 0;
					int totalTrades = 0;
					bool enoughMoney = true;
					foreach (DataGridViewRow row in SellOffersData.Rows) {
						if (Convert.ToBoolean(row.Cells["BuyCheck"].Value)) {
							bool success = true;
							UInt32 requestID = Convert.ToUInt32(row.Cells[0].Value);
							UInt32 buyQuantity = Convert.ToUInt32(row.Cells["BuyQuantity"].Value);

							string query = "SELECT id_seller, id_item, price "
								+ "FROM itemstosell WHERE id_request='" + requestID.ToString() + "'";
							MySqlDataAdapter msda = new MySqlDataAdapter(query, Con);
							DataSet ds = new DataSet();
							msda.Fill(ds);
							DataRow dbrow = ds.Tables[0].Rows[0];
							string queryMon = "CALL checkMoney('" + UserID.ToString() + "', '"
								+ (Convert.ToUInt32(dbrow["price"]) * buyQuantity).ToString() + "', @mon); "
								+ "SELECT @mon";
							MySqlCommand cmdMon = new MySqlCommand(queryMon, Con);
							if (Convert.ToInt32(cmdMon.ExecuteScalar()) == 1) {
								string query1 = "CALL removeSellRequest('" + requestID.ToString()
								+ "', '" + buyQuantity.ToString() + "'); CALL trade('"
								+ dbrow["id_seller"].ToString() + "', '" + UserID.ToString() + "', '"
								+ dbrow["id_item"].ToString() + "', '" + buyQuantity.ToString() + "', '"
								+ dbrow["price"].ToString() + "')";
								MySqlCommand cmd = new MySqlCommand(query1, Con);
								try {
									cmd.ExecuteNonQuery();
								}
								catch (Exception ex) {
									MessageBox.Show("Произошла ошибка при выполнении транзакции.\n" + ex.Message,
										"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
									success = false;
								}
								if (success) {
									successfulTrades++;
								}
							}
							else {
								enoughMoney = false;
							}
							totalTrades++;
						}
					}
					MessageBox.Show("Куплено предметов: " + successfulTrades.ToString()
						+ " из " + totalTrades.ToString()
						+ (enoughMoney ? "" : "\nНедостаточно средств"));
				}
				CloseCon();
			}
			/*
			UInt32 sum = 0;
			foreach (DataGridViewRow row in SellOffersData.Rows) {
				if (Convert.ToBoolean(row.Cells[5].Value)) {
					string s = "SELECT id_seller, id_item, quantity, price FROM itemstosell WHERE id_request='" + row.Cells[0].Value.ToString() + "'";
					MySqlDataAdapter ssda = new MySqlDataAdapter(s, con);
					
					DataSet sds = new DataSet();
					ssda.Fill(sds);
					if (sds.Tables[0].Rows.Count == 1) {
						string query;
						string requestID = row.Cells[0].Value.ToString();
						UInt32 sellerID = Convert.ToUInt32(sds.Tables[0].Rows[0][0]);
						UInt32 sellItemID = Convert.ToUInt32(sds.Tables[0].Rows[0][1]);
						UInt32 inStock = Convert.ToUInt32(sds.Tables[0].Rows[0][2]);
						UInt32 price = Convert.ToUInt32(sds.Tables[0].Rows[0][3]);
						UInt32 required = Convert.ToUInt32(row.Cells[6].Value);
						
						if (inStock == required) {
							query = "DELETE from itemstosell WHERE id_request='" + requestID + "'";
						}
						else if (inStock > required) {
							query = "UPDATE itemstosell SET quantity=quantity-'" + required.ToString() + "' "
								+ "WHERE id_request='" + requestID + "'";
						}
						else {
							continue;
						}
						MySqlCommand cmd = new MySqlCommand(query, con);
						try {
							cmd.ExecuteNonQuery();
						}
						catch (MySqlException ex) {
							MessageBox.Show("Произошла ошибка при выполнении транзакции. "
								+ "Пожалуйста, обновите таблицу и повторите попытку" + ex.ToString());
						}
						string getItemQuery = "CALL getItem('" + sellerID.ToString() + "', '"
							+ sellItemID.ToString() + "', '" + required.ToString() + "')";

						MySqlCommand getItemCmd = new MySqlCommand(getItemQuery, con);
						try {
							getItemCmd.ExecuteNonQuery();
						}
						catch (Exception) {
							MessageBox.Show("Произошла ошибка при взятии предмета у продавца");
						}

						string getMoneyQuery = "CALL getMoney('" + UserID.ToString() + "', '"
							+ (required * price).ToString() + "')";
						MySqlCommand getMoneyCmd = new MySqlCommand(getMoneyQuery, con);
						try {
							getMoneyCmd.ExecuteNonQuery();
						}
						catch (Exception) {
							MessageBox.Show("Произошла ошибка при взятии денег у покупателя");
						}

						string giveItemQuery = "CALL giveItem('" + UserID.ToString() + "', '"
							+ sellItemID.ToString() + "', '" + required.ToString() + "')";
						MySqlCommand giveItemCmd = new MySqlCommand(giveItemQuery, con);
						try {
							giveItemCmd.ExecuteNonQuery();
						}
						catch (Exception) {
							MessageBox.Show("Произошла ошибка при передаче предмета покупателю");
						}

						string giveMoneyQuery = "CALL giveMoney('" + sellerID.ToString() + "', '"
							+ (required * price).ToString() + "')";
						MySqlCommand giveMoneyCmd = new MySqlCommand(giveMoneyQuery, con);
						try {
							giveMoneyCmd.ExecuteNonQuery();
						}
						catch (Exception) {
							MessageBox.Show("Произошла ошибка при передаче денег продавцу");
						}

						string insertQuery = "INSERT INTO trades (id_item, id_buyer, id_seller, quantity, price) "
							+ "VALUES ('" + ItemID.ToString() + "', '" + UserID.ToString() + "', '"
							+ row.Cells[1].ToString() + "', '" + required.ToString() + "', '"
							+ price.ToString() + "')";
						MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);
						try {
							cmd.ExecuteNonQuery();
						}
						catch (Exception) {
							MessageBox.Show("Произошла ошибка при записи сделки. "
								+ "Пожалуйста, обновите таблицу и повторите попытку");
						}
						sum += required * price;
					}
				}
			}
			con.Close();*/
		}

		private bool ConfirmSell() {
			DialogResult dialogResult = MessageBox.Show("Продать предметы?", "Подтверждение", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes) {
				return true;
			}
			return false;
		}

		private bool CheckSellData() {
			UInt32 totalPrice = 0;
			UInt32 index = 0;
			try {
				foreach (DataGridViewRow row in BuyOffersData.Rows) {
					index++;
					if (Convert.ToBoolean(row.Cells["SellCheck"].Value)) {
						if (Convert.ToUInt32(row.Cells["SellQuantity"].Value) >
							Convert.ToUInt32(row.Cells["BuyItemQuantity"].Value)) {
							throw new ArgumentOutOfRangeException();
						}
						totalPrice += Convert.ToUInt32(row.Cells["BuyItemPrice"].Value) *
							Convert.ToUInt32(row.Cells["SellQuantity"].Value);
						
					}
				}
			}
			catch (ArgumentOutOfRangeException) {
				MessageBox.Show("Выбрано слишком большое значение в строке " + index.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			catch (Exception) {
				MessageBox.Show("Неправильное значение в строке " + index.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (totalPrice == 0) {
				MessageBox.Show("Предметы не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			/*else {
				string query = "CALL checkMoney('" + userID.ToString() + "', '" + totalPrice.ToString() + "')";
				MySqlCommand cmd = new MySqlCommand(query, Con);
				try {
					if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) {
						MessageBox.Show("Недостаточно средств у покупателя");
						return false;
					}
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message);
					return false;
				}
			}*/
			return true;
		}

		private void SellButton_Click(object sender, EventArgs e) {
			if (OpenCon()) {
				if (CheckSellData() && ConfirmSell()) {
					int successfulTrades = 0;
					int totalTrades = 0;
					bool enoughMoney = true;
					bool enoughItems = true;
					foreach (DataGridViewRow row in BuyOffersData.Rows) {
						if (Convert.ToBoolean(row.Cells["SellCheck"].Value)) {
							UInt32 requestID = Convert.ToUInt32(row.Cells[0].Value);
							UInt32 sellQuantity = Convert.ToUInt32(row.Cells["SellQuantity"].Value);

							string queryQuan = "CALL checkQuantity('" + UserID.ToString() + "', '"
								+ ItemID.ToString() + "', '"
								+ sellQuantity.ToString() + "', @quan); "
								+ "SELECT @quan";
							MySqlCommand cmdQuan = new MySqlCommand(queryQuan, Con);
							if (Convert.ToInt32(cmdQuan.ExecuteScalar()) == 1) {
								string query1 = "SELECT id_item, id_buyer, price "
									+ "FROM itemstobuy WHERE id_request='" + requestID.ToString() + "'";
								MySqlDataAdapter msda = new MySqlDataAdapter(query1, Con);
								DataSet ds = new DataSet();
								msda.Fill(ds);
								DataRow dbrow = ds.Tables[0].Rows[0];
								string queryMon = "CALL checkMoney('" + dbrow["id_buyer"].ToString() + "', '"
									+ (Convert.ToUInt32(dbrow["price"]) * sellQuantity).ToString() + "', @mon); "
									+ "SELECT @mon";
								MySqlCommand cmdMon = new MySqlCommand(queryMon, Con);
								if (Convert.ToInt32(cmdMon.ExecuteScalar()) == 1) {
									bool success = true;
									string query2 = "CALL removeBuyRequest('" + requestID.ToString() + "', '" + sellQuantity.ToString() + "'); "
										+ "CALL trade('" + UserID.ToString() + "', '" + dbrow["id_buyer"].ToString()
										+ "', '" + dbrow["id_item"].ToString() + "', '" + sellQuantity.ToString()
										+ "', '" + dbrow["price"].ToString() + "')";
									MySqlCommand cmd1 = new MySqlCommand(query2, Con);
									try {
										cmd1.ExecuteNonQuery();
									}
									catch(Exception ex) {
										MessageBox.Show("Произошла ошибка при выполнении транзакции.\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
										success = false;
									}
									if (success) {
										successfulTrades++;
									}
								}
								else {
									enoughMoney = false;
								}
							}
							else {
								enoughItems = false;
							}
							totalTrades++;
						}
					}
					MessageBox.Show("Продано предметов: " + successfulTrades.ToString() + " из " + totalTrades.ToString()
						+ (enoughMoney ? "" : "\nУ покупателя недостаточно средств")
						+ (enoughItems ? "" : "\nНедостаточно предметов"));
				}
				
				CloseCon();
			}
		}

		private void SellOffersData_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}

		private void button1_Click(object sender, EventArgs e) {
			SellItemForm sellItemForm = new SellItemForm(ItemID, UserID, this);
			sellItemForm.Show();
		}

		private void BuyRequestButton_Click(object sender, EventArgs e) {
			BuyItemForm buyItemForm = new BuyItemForm(ItemID, UserID, this);
			buyItemForm.Show();
		}
	}
}
