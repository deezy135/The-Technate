namespace tm1 {
	partial class SellItemForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellItemForm));
			this.PriceTextBox = new System.Windows.Forms.TextBox();
			this.SellItemGroupBox = new System.Windows.Forms.GroupBox();
			this.PriceLabel = new System.Windows.Forms.Label();
			this.QuantityLabel = new System.Windows.Forms.Label();
			this.QuantityTextBox = new System.Windows.Forms.TextBox();
			this.SellRequestButton = new System.Windows.Forms.Button();
			this.SellItemGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// PriceTextBox
			// 
			this.PriceTextBox.Location = new System.Drawing.Point(76, 19);
			this.PriceTextBox.Name = "PriceTextBox";
			this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
			this.PriceTextBox.TabIndex = 0;
			// 
			// SellItemGroupBox
			// 
			this.SellItemGroupBox.Controls.Add(this.SellRequestButton);
			this.SellItemGroupBox.Controls.Add(this.QuantityLabel);
			this.SellItemGroupBox.Controls.Add(this.PriceLabel);
			this.SellItemGroupBox.Controls.Add(this.QuantityTextBox);
			this.SellItemGroupBox.Controls.Add(this.PriceTextBox);
			this.SellItemGroupBox.Location = new System.Drawing.Point(12, 12);
			this.SellItemGroupBox.Name = "SellItemGroupBox";
			this.SellItemGroupBox.Size = new System.Drawing.Size(210, 112);
			this.SellItemGroupBox.TabIndex = 1;
			this.SellItemGroupBox.TabStop = false;
			this.SellItemGroupBox.Text = "Установка цены и количества";
			// 
			// PriceLabel
			// 
			this.PriceLabel.AutoSize = true;
			this.PriceLabel.Location = new System.Drawing.Point(37, 22);
			this.PriceLabel.Name = "PriceLabel";
			this.PriceLabel.Size = new System.Drawing.Size(33, 13);
			this.PriceLabel.TabIndex = 1;
			this.PriceLabel.Text = "Цена";
			// 
			// QuantityLabel
			// 
			this.QuantityLabel.AutoSize = true;
			this.QuantityLabel.Location = new System.Drawing.Point(29, 48);
			this.QuantityLabel.Name = "QuantityLabel";
			this.QuantityLabel.Size = new System.Drawing.Size(41, 13);
			this.QuantityLabel.TabIndex = 1;
			this.QuantityLabel.Text = "Кол-во";
			// 
			// QuantityTextBox
			// 
			this.QuantityTextBox.Location = new System.Drawing.Point(76, 45);
			this.QuantityTextBox.Name = "QuantityTextBox";
			this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
			this.QuantityTextBox.TabIndex = 1;
			// 
			// SellRequestButton
			// 
			this.SellRequestButton.Location = new System.Drawing.Point(32, 83);
			this.SellRequestButton.Name = "SellRequestButton";
			this.SellRequestButton.Size = new System.Drawing.Size(144, 23);
			this.SellRequestButton.TabIndex = 2;
			this.SellRequestButton.Text = "Выставить на продажу";
			this.SellRequestButton.UseVisualStyleBackColor = true;
			this.SellRequestButton.Click += new System.EventHandler(this.SellRequestButton_Click);
			// 
			// SellItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 136);
			this.Controls.Add(this.SellItemGroupBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SellItemForm";
			this.Text = "Выставить предмет";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SellItemForm_FormClosed);
			this.SellItemGroupBox.ResumeLayout(false);
			this.SellItemGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox PriceTextBox;
		private System.Windows.Forms.GroupBox SellItemGroupBox;
		private System.Windows.Forms.Label QuantityLabel;
		private System.Windows.Forms.Label PriceLabel;
		private System.Windows.Forms.TextBox QuantityTextBox;
		private System.Windows.Forms.Button SellRequestButton;
	}
}