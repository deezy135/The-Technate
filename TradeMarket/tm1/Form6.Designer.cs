namespace tm1 {
	partial class BuyItemForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyItemForm));
			this.BuyItemGroupBox = new System.Windows.Forms.GroupBox();
			this.BuyRequestButton = new System.Windows.Forms.Button();
			this.QuantityLabel = new System.Windows.Forms.Label();
			this.PriceLabel = new System.Windows.Forms.Label();
			this.QuantityTextBox = new System.Windows.Forms.TextBox();
			this.PriceTextBox = new System.Windows.Forms.TextBox();
			this.BuyItemGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// BuyItemGroupBox
			// 
			this.BuyItemGroupBox.Controls.Add(this.BuyRequestButton);
			this.BuyItemGroupBox.Controls.Add(this.QuantityLabel);
			this.BuyItemGroupBox.Controls.Add(this.PriceLabel);
			this.BuyItemGroupBox.Controls.Add(this.QuantityTextBox);
			this.BuyItemGroupBox.Controls.Add(this.PriceTextBox);
			this.BuyItemGroupBox.Location = new System.Drawing.Point(12, 12);
			this.BuyItemGroupBox.Name = "BuyItemGroupBox";
			this.BuyItemGroupBox.Size = new System.Drawing.Size(210, 112);
			this.BuyItemGroupBox.TabIndex = 2;
			this.BuyItemGroupBox.TabStop = false;
			this.BuyItemGroupBox.Text = "Установка цены и количества";
			// 
			// BuyRequestButton
			// 
			this.BuyRequestButton.Location = new System.Drawing.Point(32, 83);
			this.BuyRequestButton.Name = "BuyRequestButton";
			this.BuyRequestButton.Size = new System.Drawing.Size(144, 23);
			this.BuyRequestButton.TabIndex = 2;
			this.BuyRequestButton.Text = "Заказать";
			this.BuyRequestButton.UseVisualStyleBackColor = true;
			this.BuyRequestButton.Click += new System.EventHandler(this.BuyRequestButton_Click);
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
			// PriceLabel
			// 
			this.PriceLabel.AutoSize = true;
			this.PriceLabel.Location = new System.Drawing.Point(37, 22);
			this.PriceLabel.Name = "PriceLabel";
			this.PriceLabel.Size = new System.Drawing.Size(33, 13);
			this.PriceLabel.TabIndex = 1;
			this.PriceLabel.Text = "Цена";
			// 
			// QuantityTextBox
			// 
			this.QuantityTextBox.Location = new System.Drawing.Point(76, 45);
			this.QuantityTextBox.Name = "QuantityTextBox";
			this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
			this.QuantityTextBox.TabIndex = 1;
			// 
			// PriceTextBox
			// 
			this.PriceTextBox.Location = new System.Drawing.Point(76, 19);
			this.PriceTextBox.Name = "PriceTextBox";
			this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
			this.PriceTextBox.TabIndex = 0;
			// 
			// BuyItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 136);
			this.Controls.Add(this.BuyItemGroupBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "BuyItemForm";
			this.Text = "Заказать предмет";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuyItemForm_FormClosed);
			this.BuyItemGroupBox.ResumeLayout(false);
			this.BuyItemGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox BuyItemGroupBox;
		private System.Windows.Forms.Button BuyRequestButton;
		private System.Windows.Forms.Label QuantityLabel;
		private System.Windows.Forms.Label PriceLabel;
		private System.Windows.Forms.TextBox QuantityTextBox;
		private System.Windows.Forms.TextBox PriceTextBox;
	}
}