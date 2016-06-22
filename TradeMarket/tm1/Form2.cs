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
    public partial class LoginForm : Form {
        MainForm MainForm;
		private MySqlConnection Con;
		private string ConString;
		public uint UserID;
		public LoginForm(MainForm mainForm) {
            InitializeComponent();
			MainForm = mainForm;
			ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			Con = new MySqlConnection(ConString);
			UserID = 0;
			DialogResult = DialogResult.None;
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

		private void LoginButton_Click(object sender, EventArgs e) {
			if (LoginTextBox.Text == "") {
				MessageBox.Show("Введите логин");
				return;
			}
			if (PasswordTextBox.Text == "") {
				MessageBox.Show("Введите пароль");
				return;
			}
			if (OpenCon()) {
				try {
					string query = "SELECT id_user, login, password FROM users where " +
						 "users.login='" + LoginTextBox.Text + "' and users.password='" +
						 PasswordTextBox.Text + "'";
					MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
					DataSet ds = new DataSet();
					sda.Fill(ds);
					if (ds.Tables[0].Rows.Count == 1) {
						UserID = Convert.ToUInt32(ds.Tables[0].Rows[0]["id_user"]);
						Hide();
					}
					else {
						MessageBox.Show("Неправильный логин и/или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (MySqlException ex) {
					MessageBox.Show(ex.ToString());
				}
				CloseCon();
			}
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e) {
            MainForm.Close();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                LoginButton.PerformClick();
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                LoginButton.PerformClick();
            }
        }

		private void CreateAccountButton_Click(object sender, EventArgs e) {
			SignUpForm signUpForm = new SignUpForm();
			signUpForm.ShowDialog();
			//signUpForm.Show();
		}
	}
}
