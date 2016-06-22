namespace tm1
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.LoginGroupBox = new System.Windows.Forms.GroupBox();
			this.CreateAccountButton = new System.Windows.Forms.Button();
			this.RememberCheckBox = new System.Windows.Forms.CheckBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.LoginLabel = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.LoginGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// LoginGroupBox
			// 
			this.LoginGroupBox.Controls.Add(this.CreateAccountButton);
			this.LoginGroupBox.Controls.Add(this.RememberCheckBox);
			this.LoginGroupBox.Controls.Add(this.LoginButton);
			this.LoginGroupBox.Controls.Add(this.PasswordLabel);
			this.LoginGroupBox.Controls.Add(this.LoginLabel);
			this.LoginGroupBox.Controls.Add(this.PasswordTextBox);
			this.LoginGroupBox.Controls.Add(this.LoginTextBox);
			this.LoginGroupBox.Location = new System.Drawing.Point(13, 13);
			this.LoginGroupBox.Name = "LoginGroupBox";
			this.LoginGroupBox.Size = new System.Drawing.Size(296, 133);
			this.LoginGroupBox.TabIndex = 0;
			this.LoginGroupBox.TabStop = false;
			this.LoginGroupBox.Text = "Вход в систему";
			// 
			// CreateAccountButton
			// 
			this.CreateAccountButton.Location = new System.Drawing.Point(160, 94);
			this.CreateAccountButton.Name = "CreateAccountButton";
			this.CreateAccountButton.Size = new System.Drawing.Size(116, 23);
			this.CreateAccountButton.TabIndex = 4;
			this.CreateAccountButton.Text = "Регистрация";
			this.CreateAccountButton.UseVisualStyleBackColor = true;
			this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
			// 
			// RememberCheckBox
			// 
			this.RememberCheckBox.AutoSize = true;
			this.RememberCheckBox.Location = new System.Drawing.Point(78, 71);
			this.RememberCheckBox.Name = "RememberCheckBox";
			this.RememberCheckBox.Size = new System.Drawing.Size(82, 17);
			this.RememberCheckBox.TabIndex = 2;
			this.RememberCheckBox.Text = "Запомнить";
			this.RememberCheckBox.UseVisualStyleBackColor = true;
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(78, 94);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(75, 23);
			this.LoginButton.TabIndex = 3;
			this.LoginButton.Text = "Войти";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Location = new System.Drawing.Point(27, 48);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
			this.PasswordLabel.TabIndex = 6;
			this.PasswordLabel.Text = "Пароль";
			// 
			// LoginLabel
			// 
			this.LoginLabel.AutoSize = true;
			this.LoginLabel.Location = new System.Drawing.Point(34, 22);
			this.LoginLabel.Name = "LoginLabel";
			this.LoginLabel.Size = new System.Drawing.Size(38, 13);
			this.LoginLabel.TabIndex = 5;
			this.LoginLabel.Text = "Логин";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(78, 45);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(198, 20);
			this.PasswordTextBox.TabIndex = 1;
			this.PasswordTextBox.UseSystemPasswordChar = true;
			this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
			this.PasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.Location = new System.Drawing.Point(78, 19);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(198, 20);
			this.LoginTextBox.TabIndex = 0;
			this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 158);
			this.Controls.Add(this.LoginGroupBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.Text = "Вход в систему - Торговая площадка";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
			this.LoginGroupBox.ResumeLayout(false);
			this.LoginGroupBox.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.CheckBox RememberCheckBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
    }
}