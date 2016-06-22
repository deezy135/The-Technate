namespace tm1 {
	partial class SignUpForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
			this.SignUpGroupBox = new System.Windows.Forms.GroupBox();
			this.SignUpButton = new System.Windows.Forms.Button();
			this.FileDialogButton = new System.Windows.Forms.Button();
			this.PaswordCheckLabel = new System.Windows.Forms.Label();
			this.ImageLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.LoginLabel = new System.Windows.Forms.Label();
			this.ImageTextBox = new System.Windows.Forms.TextBox();
			this.PasswordCheckTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.SignUpGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// SignUpGroupBox
			// 
			this.SignUpGroupBox.Controls.Add(this.SignUpButton);
			this.SignUpGroupBox.Controls.Add(this.FileDialogButton);
			this.SignUpGroupBox.Controls.Add(this.PaswordCheckLabel);
			this.SignUpGroupBox.Controls.Add(this.ImageLabel);
			this.SignUpGroupBox.Controls.Add(this.PasswordLabel);
			this.SignUpGroupBox.Controls.Add(this.NameLabel);
			this.SignUpGroupBox.Controls.Add(this.LoginLabel);
			this.SignUpGroupBox.Controls.Add(this.ImageTextBox);
			this.SignUpGroupBox.Controls.Add(this.PasswordCheckTextBox);
			this.SignUpGroupBox.Controls.Add(this.PasswordTextBox);
			this.SignUpGroupBox.Controls.Add(this.NameTextBox);
			this.SignUpGroupBox.Controls.Add(this.LoginTextBox);
			this.SignUpGroupBox.Location = new System.Drawing.Point(13, 13);
			this.SignUpGroupBox.Name = "SignUpGroupBox";
			this.SignUpGroupBox.Size = new System.Drawing.Size(259, 184);
			this.SignUpGroupBox.TabIndex = 0;
			this.SignUpGroupBox.TabStop = false;
			this.SignUpGroupBox.Text = "Данные пользователя";
			// 
			// SignUpButton
			// 
			this.SignUpButton.Location = new System.Drawing.Point(53, 155);
			this.SignUpButton.Name = "SignUpButton";
			this.SignUpButton.Size = new System.Drawing.Size(152, 23);
			this.SignUpButton.TabIndex = 6;
			this.SignUpButton.Text = "Зарегистрироваться";
			this.SignUpButton.UseVisualStyleBackColor = true;
			this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
			// 
			// FileDialogButton
			// 
			this.FileDialogButton.Location = new System.Drawing.Point(207, 121);
			this.FileDialogButton.Name = "FileDialogButton";
			this.FileDialogButton.Size = new System.Drawing.Size(46, 23);
			this.FileDialogButton.TabIndex = 5;
			this.FileDialogButton.Text = "...";
			this.FileDialogButton.UseVisualStyleBackColor = true;
			this.FileDialogButton.Click += new System.EventHandler(this.FileDialogButton_Click);
			// 
			// PaswordCheckLabel
			// 
			this.PaswordCheckLabel.AutoSize = true;
			this.PaswordCheckLabel.Location = new System.Drawing.Point(7, 100);
			this.PaswordCheckLabel.Name = "PaswordCheckLabel";
			this.PaswordCheckLabel.Size = new System.Drawing.Size(88, 13);
			this.PaswordCheckLabel.TabIndex = 1;
			this.PaswordCheckLabel.Text = "Подтверждение";
			// 
			// ImageLabel
			// 
			this.ImageLabel.AutoSize = true;
			this.ImageLabel.Location = new System.Drawing.Point(18, 126);
			this.ImageLabel.Name = "ImageLabel";
			this.ImageLabel.Size = new System.Drawing.Size(77, 13);
			this.ImageLabel.TabIndex = 1;
			this.ImageLabel.Text = "Изображение";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(50, 74);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
			this.PasswordLabel.TabIndex = 1;
			this.PasswordLabel.Text = "Пароль";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(66, 22);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(29, 13);
			this.NameLabel.TabIndex = 1;
			this.NameLabel.Text = "Имя";
			// 
			// LoginLabel
			// 
			this.LoginLabel.AutoSize = true;
			this.LoginLabel.Location = new System.Drawing.Point(57, 48);
			this.LoginLabel.Name = "LoginLabel";
			this.LoginLabel.Size = new System.Drawing.Size(38, 13);
			this.LoginLabel.TabIndex = 1;
			this.LoginLabel.Text = "Логин";
			// 
			// ImageTextBox
			// 
			this.ImageTextBox.Location = new System.Drawing.Point(101, 123);
			this.ImageTextBox.Name = "ImageTextBox";
			this.ImageTextBox.Size = new System.Drawing.Size(100, 20);
			this.ImageTextBox.TabIndex = 4;
			// 
			// PasswordCheckTextBox
			// 
			this.PasswordCheckTextBox.Location = new System.Drawing.Point(101, 97);
			this.PasswordCheckTextBox.Name = "PasswordCheckTextBox";
			this.PasswordCheckTextBox.PasswordChar = '*';
			this.PasswordCheckTextBox.Size = new System.Drawing.Size(100, 20);
			this.PasswordCheckTextBox.TabIndex = 3;
			this.PasswordCheckTextBox.UseSystemPasswordChar = true;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(101, 71);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
			this.PasswordTextBox.TabIndex = 2;
			this.PasswordTextBox.UseSystemPasswordChar = true;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(101, 19);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(100, 20);
			this.NameTextBox.TabIndex = 0;
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.Location = new System.Drawing.Point(101, 45);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(100, 20);
			this.LoginTextBox.TabIndex = 1;
			// 
			// SignUpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 209);
			this.Controls.Add(this.SignUpGroupBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SignUpForm";
			this.Text = "Регистрация";
			this.SignUpGroupBox.ResumeLayout(false);
			this.SignUpGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox SignUpGroupBox;
		private System.Windows.Forms.Button SignUpButton;
		private System.Windows.Forms.Button FileDialogButton;
		private System.Windows.Forms.Label PaswordCheckLabel;
		private System.Windows.Forms.Label ImageLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label LoginLabel;
		private System.Windows.Forms.TextBox ImageTextBox;
		private System.Windows.Forms.TextBox PasswordCheckTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox LoginTextBox;
	}
}