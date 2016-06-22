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
	public partial class SignUpForm : Form {
		private MySqlConnection Con;
		private string ConString;
		private OpenFileDialog openFileDialog;
		public SignUpForm() {
			InitializeComponent();
			ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
			Con = new MySqlConnection(ConString);
			openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Выберите файл";
			openFileDialog.Filter = "Изображения (*.bmp, *.jpg, *.png, *.jpeg)|*.bmp;*.jpg;*.png;*.jpeg";

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

		private int CheckPassword(string password) {
			int result = 0;
			int letters = 0;
			int nums = 0;
			if (password.Length < 6 || password.Length > 20) {
				result = 1;
				return result;
			}
			for (int i = 0; i < password.Length; i++) {
				if ('a' <= password[i] && password[i] <= 'z' || 'A' <= password[i] && password[i] <= 'Z') {
					letters++;
				}
				else if ('0' <= password[i] && password[i] <= '9') {
					nums++;
				}
				else {
					result = 2;
					break;
				}
			}
			if (result == 0 && (letters == 0 || nums == 0)) {
				result = 3;
			}
			return result;
		}

		private int CheckLogin(string login) {
			int result = 0;
			if (login.Length < 4 || login.Length > 15) {
				result = 1;
				return result;
			}
			for (int i = 0; i < login.Length; i++) {
				if (!('a' <= login[i] && login[i] <= 'z' 
					|| 'A' <= login[i] && login[i] <= 'Z' 
					|| '0' <= login[i] && login[i] <= '9')) {
					result = 2;
					break;
				}
			}
			if (result == 0 && OpenCon()) {
				string query = "SELECT COUNT(login) FROM users WHERE login='" + login + "'";
				MySqlCommand cmd = new MySqlCommand(query, Con);
				if (Convert.ToInt32(cmd.ExecuteScalar()) == 1) {
					result = 3;
				}
				CloseCon();
			}
			return result;
		}

		private void SignUpButton_Click(object sender, EventArgs e) {
			if (NameTextBox.Text == "") {
				MessageBox.Show("Введите имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (LoginTextBox.Text == "") {
				MessageBox.Show("Введите логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (PasswordTextBox.Text == "") {
				MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (PasswordCheckTextBox.Text == "") {
				MessageBox.Show("Подтвердите пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (ImageTextBox.Text == "") {
				MessageBox.Show("Выберите файл изображения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			switch (CheckLogin(LoginTextBox.Text)) {
				case 1:
					MessageBox.Show("Длина логина должна быть от 4 до 15 символов",
						"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				case 2:
					MessageBox.Show("Логин должен состоять из символов латинского алфавита и цифр",
						"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				case 3:
					MessageBox.Show("Пользователь с таким логином уже зарегистрирован",
						"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
			}
			switch (CheckPassword(PasswordTextBox.Text)) {
				case 1:
					MessageBox.Show("Длина пароля должна быть от 6 до 20 символов",
						"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				case 2:
					MessageBox.Show("Пароль должен состоять из символов латинского алфавита и цифр",
						"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				case 3:
					MessageBox.Show("Пароль должен содержать по крайней мере одну цифру и одну букву",
						"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
			}
			if (PasswordCheckTextBox.Text.Equals(PasswordTextBox.Text) == false) {
				MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (ImageTextBox.Text[0] != 'C') {
				MessageBox.Show("Файл не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (OpenCon()) {
				bool success = true;
				string query = "INSERT INTO users (login, password, name, money, image) VALUES ('"
					+ LoginTextBox.Text + "', '" + PasswordTextBox.Text + "', '" + NameTextBox.Text + "', '"
					+ (1000).ToString() + "', ?image)";
				MySqlCommand cmd = new MySqlCommand(query, Con);
				cmd.Prepare();
				cmd.Parameters.AddWithValue("?image", ImageTextBox.Text);
				try {
					cmd.ExecuteNonQuery();
				}
				catch(Exception ex) {
					MessageBox.Show(ex.Message);
					success = false;
				}
				CloseCon();

				if (success) {
					MessageBox.Show("Регистрация прошла успешно");
					Close();
				}
			}
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
			
		}

		private void FileDialogButton_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				ImageTextBox.Text = @openFileDialog.FileName;
			}
		}
	}
}
