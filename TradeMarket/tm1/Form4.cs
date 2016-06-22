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
	public partial class TraderForm : Form {
		UInt32 TraderID;
		public TraderForm(UInt32 traderID) {
			InitializeComponent();
			TraderID = traderID;
			RefreshForm();
		}

		private void RefreshForm() {
			string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			MySqlConnection con = new MySqlConnection(ConString);
			string CmdString = "SELECT * FROM users WHERE id_user='" + TraderID.ToString() + "'";
			MySqlDataAdapter sda = new MySqlDataAdapter(CmdString, con);
			DataSet ds = new DataSet();
			sda.Fill(ds);

			//this.Icon.Dispose();
			//this.Icon = new Icon(ds.Tables[0].Rows[0]["image"].ToString());
			TraderImage.ImageLocation = ds.Tables[0].Rows[0]["image"].ToString();
			TraderNameLabel.Text = ds.Tables[0].Rows[0]["name"].ToString();
			TraderDescriptionTextBox.Text = "Баланс: " + ds.Tables[0].Rows[0]["money"].ToString();
			string CmdString1 = "SELECT items.id_item, name, quantity, price FROM itemstobuy, items " +
				"where id_buyer='" + TraderID.ToString() + "' and itemstobuy.id_item=items.id_item ORDER BY price";
			MySqlDataAdapter itemstobuy = new MySqlDataAdapter(CmdString1, con);
			DataSet itemstobuyds = new DataSet();
			itemstobuy.Fill(itemstobuyds);
			foreach (DataRow row in itemstobuyds.Tables[0].Rows) {
				object[] values ={
					row["id_item"], row["name"], row["quantity"], row["price"], false, row["quantity"]
				};
				BuyOffersData.Rows.Add(values);
			}
			string CmdString2 = "SELECT items.id_item, name, quantity, price FROM itemstosell, items " +
				"where id_seller='" + TraderID.ToString() + "' and itemstosell.id_item=items.id_item ORDER BY price";
			MySqlDataAdapter itemstosell = new MySqlDataAdapter(CmdString2, con);
			DataSet itemstosellds = new DataSet();
			itemstosell.Fill(itemstosellds);
			foreach (DataRow row in itemstosellds.Tables[0].Rows) {
				object[] values ={
					row["id_item"], row["name"], row["quantity"], row["price"], false, row["quantity"]
				};
				SellOffersData.Rows.Add(values);
			}
			con.Close();
		}
		private void TraderForm_Load(object sender, EventArgs e) {

		}

		private void BuyButton_Click(object sender, EventArgs e) {

		}
	}
}
