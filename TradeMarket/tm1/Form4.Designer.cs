namespace tm1 {
	partial class TraderForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraderForm));
			this.TraderInfoGroupBox = new System.Windows.Forms.GroupBox();
			this.TraderDescriptionTextBox = new System.Windows.Forms.TextBox();
			this.TraderNameLabel = new System.Windows.Forms.Label();
			this.TraderImage = new System.Windows.Forms.PictureBox();
			this.TraderTabs = new System.Windows.Forms.TabControl();
			this.SellOffersTab = new System.Windows.Forms.TabPage();
			this.SellOffersData = new System.Windows.Forms.DataGridView();
			this.SellItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SellItemName = new System.Windows.Forms.DataGridViewLinkColumn();
			this.SellItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SellItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BuyCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BuyQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BuyButton = new System.Windows.Forms.Button();
			this.BuyOffersTab = new System.Windows.Forms.TabPage();
			this.SellButton = new System.Windows.Forms.Button();
			this.BuyOffersData = new System.Windows.Forms.DataGridView();
			this.BuyItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BuyItemName = new System.Windows.Forms.DataGridViewLinkColumn();
			this.BuyItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BuyItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SellCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.SellQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TradesTab = new System.Windows.Forms.TabPage();
			this.TradesData = new System.Windows.Forms.DataGridView();
			this.TradeSellerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TradeBuyerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TradeSellerName = new System.Windows.Forms.DataGridViewLinkColumn();
			this.TradeBuyerName = new System.Windows.Forms.DataGridViewLinkColumn();
			this.TradeQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TradePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TradeDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TraderInfoGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TraderImage)).BeginInit();
			this.TraderTabs.SuspendLayout();
			this.SellOffersTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SellOffersData)).BeginInit();
			this.BuyOffersTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BuyOffersData)).BeginInit();
			this.TradesTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TradesData)).BeginInit();
			this.SuspendLayout();
			// 
			// TraderInfoGroupBox
			// 
			this.TraderInfoGroupBox.Controls.Add(this.TraderDescriptionTextBox);
			this.TraderInfoGroupBox.Controls.Add(this.TraderNameLabel);
			this.TraderInfoGroupBox.Controls.Add(this.TraderImage);
			this.TraderInfoGroupBox.Location = new System.Drawing.Point(12, 12);
			this.TraderInfoGroupBox.Name = "TraderInfoGroupBox";
			this.TraderInfoGroupBox.Size = new System.Drawing.Size(320, 100);
			this.TraderInfoGroupBox.TabIndex = 2;
			this.TraderInfoGroupBox.TabStop = false;
			this.TraderInfoGroupBox.Text = "Инф. о торговце";
			// 
			// TraderDescriptionTextBox
			// 
			this.TraderDescriptionTextBox.BackColor = System.Drawing.Color.White;
			this.TraderDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TraderDescriptionTextBox.Enabled = false;
			this.TraderDescriptionTextBox.Location = new System.Drawing.Point(76, 40);
			this.TraderDescriptionTextBox.Multiline = true;
			this.TraderDescriptionTextBox.Name = "TraderDescriptionTextBox";
			this.TraderDescriptionTextBox.ReadOnly = true;
			this.TraderDescriptionTextBox.Size = new System.Drawing.Size(170, 43);
			this.TraderDescriptionTextBox.TabIndex = 2;
			// 
			// TraderNameLabel
			// 
			this.TraderNameLabel.AutoSize = true;
			this.TraderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TraderNameLabel.Location = new System.Drawing.Point(76, 19);
			this.TraderNameLabel.Name = "TraderNameLabel";
			this.TraderNameLabel.Size = new System.Drawing.Size(90, 13);
			this.TraderNameLabel.TabIndex = 1;
			this.TraderNameLabel.Text = "Имя торговца";
			// 
			// TraderImage
			// 
			this.TraderImage.Location = new System.Drawing.Point(6, 19);
			this.TraderImage.Name = "TraderImage";
			this.TraderImage.Size = new System.Drawing.Size(64, 64);
			this.TraderImage.TabIndex = 0;
			this.TraderImage.TabStop = false;
			// 
			// TraderTabs
			// 
			this.TraderTabs.Controls.Add(this.SellOffersTab);
			this.TraderTabs.Controls.Add(this.BuyOffersTab);
			this.TraderTabs.Controls.Add(this.TradesTab);
			this.TraderTabs.Location = new System.Drawing.Point(12, 118);
			this.TraderTabs.Name = "TraderTabs";
			this.TraderTabs.SelectedIndex = 0;
			this.TraderTabs.Size = new System.Drawing.Size(320, 231);
			this.TraderTabs.TabIndex = 3;
			// 
			// SellOffersTab
			// 
			this.SellOffersTab.Controls.Add(this.SellOffersData);
			this.SellOffersTab.Controls.Add(this.BuyButton);
			this.SellOffersTab.Location = new System.Drawing.Point(4, 22);
			this.SellOffersTab.Name = "SellOffersTab";
			this.SellOffersTab.Padding = new System.Windows.Forms.Padding(3);
			this.SellOffersTab.Size = new System.Drawing.Size(312, 205);
			this.SellOffersTab.TabIndex = 0;
			this.SellOffersTab.Text = "На продажу";
			this.SellOffersTab.UseVisualStyleBackColor = true;
			// 
			// SellOffersData
			// 
			this.SellOffersData.AllowUserToAddRows = false;
			this.SellOffersData.AllowUserToDeleteRows = false;
			this.SellOffersData.AllowUserToResizeColumns = false;
			this.SellOffersData.AllowUserToResizeRows = false;
			this.SellOffersData.BackgroundColor = System.Drawing.Color.White;
			this.SellOffersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SellOffersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SellItemID,
            this.SellItemName,
            this.SellItemQuantity,
            this.SellItemPrice,
            this.BuyCheck,
            this.BuyQuantity});
			this.SellOffersData.Location = new System.Drawing.Point(6, 6);
			this.SellOffersData.Name = "SellOffersData";
			this.SellOffersData.RowHeadersVisible = false;
			this.SellOffersData.Size = new System.Drawing.Size(300, 160);
			this.SellOffersData.TabIndex = 2;
			// 
			// SellItemID
			// 
			this.SellItemID.HeaderText = "ID предмета";
			this.SellItemID.Name = "SellItemID";
			this.SellItemID.ReadOnly = true;
			this.SellItemID.Visible = false;
			// 
			// SellItemName
			// 
			this.SellItemName.ActiveLinkColor = System.Drawing.Color.Black;
			this.SellItemName.HeaderText = "Предмет";
			this.SellItemName.LinkColor = System.Drawing.Color.Black;
			this.SellItemName.Name = "SellItemName";
			this.SellItemName.ReadOnly = true;
			this.SellItemName.VisitedLinkColor = System.Drawing.Color.DimGray;
			this.SellItemName.Width = 70;
			// 
			// SellItemQuantity
			// 
			this.SellItemQuantity.HeaderText = "Кол-во";
			this.SellItemQuantity.Name = "SellItemQuantity";
			this.SellItemQuantity.ReadOnly = true;
			this.SellItemQuantity.Width = 50;
			// 
			// SellItemPrice
			// 
			this.SellItemPrice.HeaderText = "Цена";
			this.SellItemPrice.Name = "SellItemPrice";
			this.SellItemPrice.ReadOnly = true;
			this.SellItemPrice.Width = 40;
			// 
			// BuyCheck
			// 
			this.BuyCheck.HeaderText = "";
			this.BuyCheck.Name = "BuyCheck";
			this.BuyCheck.Width = 20;
			// 
			// BuyQuantity
			// 
			this.BuyQuantity.HeaderText = "Купить (кол-во)";
			this.BuyQuantity.Name = "BuyQuantity";
			this.BuyQuantity.Width = 117;
			// 
			// BuyButton
			// 
			this.BuyButton.Location = new System.Drawing.Point(231, 172);
			this.BuyButton.Name = "BuyButton";
			this.BuyButton.Size = new System.Drawing.Size(75, 23);
			this.BuyButton.TabIndex = 1;
			this.BuyButton.Text = "Купить";
			this.BuyButton.UseVisualStyleBackColor = true;
			this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
			// 
			// BuyOffersTab
			// 
			this.BuyOffersTab.Controls.Add(this.SellButton);
			this.BuyOffersTab.Controls.Add(this.BuyOffersData);
			this.BuyOffersTab.Location = new System.Drawing.Point(4, 22);
			this.BuyOffersTab.Name = "BuyOffersTab";
			this.BuyOffersTab.Padding = new System.Windows.Forms.Padding(3);
			this.BuyOffersTab.Size = new System.Drawing.Size(312, 205);
			this.BuyOffersTab.TabIndex = 1;
			this.BuyOffersTab.Text = "На покупку";
			this.BuyOffersTab.UseVisualStyleBackColor = true;
			// 
			// SellButton
			// 
			this.SellButton.Location = new System.Drawing.Point(231, 172);
			this.SellButton.Name = "SellButton";
			this.SellButton.Size = new System.Drawing.Size(75, 23);
			this.SellButton.TabIndex = 4;
			this.SellButton.Text = "Продать";
			this.SellButton.UseVisualStyleBackColor = true;
			// 
			// BuyOffersData
			// 
			this.BuyOffersData.AllowUserToAddRows = false;
			this.BuyOffersData.AllowUserToDeleteRows = false;
			this.BuyOffersData.AllowUserToResizeColumns = false;
			this.BuyOffersData.AllowUserToResizeRows = false;
			this.BuyOffersData.BackgroundColor = System.Drawing.Color.White;
			this.BuyOffersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BuyOffersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuyItemID,
            this.BuyItemName,
            this.BuyItemQuantity,
            this.BuyItemPrice,
            this.SellCheck,
            this.SellQuantity});
			this.BuyOffersData.Location = new System.Drawing.Point(6, 6);
			this.BuyOffersData.Name = "BuyOffersData";
			this.BuyOffersData.ReadOnly = true;
			this.BuyOffersData.RowHeadersVisible = false;
			this.BuyOffersData.Size = new System.Drawing.Size(300, 160);
			this.BuyOffersData.TabIndex = 3;
			// 
			// BuyItemID
			// 
			this.BuyItemID.HeaderText = "ID предмета";
			this.BuyItemID.Name = "BuyItemID";
			this.BuyItemID.ReadOnly = true;
			this.BuyItemID.Visible = false;
			// 
			// BuyItemName
			// 
			this.BuyItemName.ActiveLinkColor = System.Drawing.Color.Black;
			this.BuyItemName.HeaderText = "Предмет";
			this.BuyItemName.LinkColor = System.Drawing.Color.Black;
			this.BuyItemName.Name = "BuyItemName";
			this.BuyItemName.ReadOnly = true;
			this.BuyItemName.VisitedLinkColor = System.Drawing.Color.DimGray;
			this.BuyItemName.Width = 70;
			// 
			// BuyItemQuantity
			// 
			this.BuyItemQuantity.HeaderText = "Кол-во";
			this.BuyItemQuantity.Name = "BuyItemQuantity";
			this.BuyItemQuantity.ReadOnly = true;
			this.BuyItemQuantity.Width = 50;
			// 
			// BuyItemPrice
			// 
			this.BuyItemPrice.HeaderText = "Цена";
			this.BuyItemPrice.Name = "BuyItemPrice";
			this.BuyItemPrice.ReadOnly = true;
			this.BuyItemPrice.Width = 40;
			// 
			// SellCheck
			// 
			this.SellCheck.HeaderText = "";
			this.SellCheck.Name = "SellCheck";
			this.SellCheck.ReadOnly = true;
			this.SellCheck.Width = 20;
			// 
			// SellQuantity
			// 
			this.SellQuantity.HeaderText = "Продать (кол-во)";
			this.SellQuantity.Name = "SellQuantity";
			this.SellQuantity.ReadOnly = true;
			this.SellQuantity.Width = 117;
			// 
			// TradesTab
			// 
			this.TradesTab.Controls.Add(this.TradesData);
			this.TradesTab.Location = new System.Drawing.Point(4, 22);
			this.TradesTab.Name = "TradesTab";
			this.TradesTab.Padding = new System.Windows.Forms.Padding(3);
			this.TradesTab.Size = new System.Drawing.Size(312, 205);
			this.TradesTab.TabIndex = 2;
			this.TradesTab.Text = "Совершённые сделки";
			this.TradesTab.UseVisualStyleBackColor = true;
			// 
			// TradesData
			// 
			this.TradesData.AllowUserToAddRows = false;
			this.TradesData.AllowUserToDeleteRows = false;
			this.TradesData.AllowUserToResizeColumns = false;
			this.TradesData.AllowUserToResizeRows = false;
			this.TradesData.BackgroundColor = System.Drawing.Color.White;
			this.TradesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TradesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TradeSellerID,
            this.TradeBuyerID,
            this.TradeSellerName,
            this.TradeBuyerName,
            this.TradeQuantity,
            this.TradePrice,
            this.TradeDateTime});
			this.TradesData.Location = new System.Drawing.Point(6, 6);
			this.TradesData.Name = "TradesData";
			this.TradesData.ReadOnly = true;
			this.TradesData.RowHeadersVisible = false;
			this.TradesData.Size = new System.Drawing.Size(300, 193);
			this.TradesData.TabIndex = 4;
			// 
			// TradeSellerID
			// 
			this.TradeSellerID.HeaderText = "ID продавца";
			this.TradeSellerID.Name = "TradeSellerID";
			this.TradeSellerID.ReadOnly = true;
			this.TradeSellerID.Visible = false;
			// 
			// TradeBuyerID
			// 
			this.TradeBuyerID.HeaderText = "ID покупателя";
			this.TradeBuyerID.Name = "TradeBuyerID";
			this.TradeBuyerID.ReadOnly = true;
			this.TradeBuyerID.Visible = false;
			// 
			// TradeSellerName
			// 
			this.TradeSellerName.ActiveLinkColor = System.Drawing.Color.Black;
			this.TradeSellerName.HeaderText = "Продавец";
			this.TradeSellerName.LinkColor = System.Drawing.Color.Black;
			this.TradeSellerName.Name = "TradeSellerName";
			this.TradeSellerName.ReadOnly = true;
			this.TradeSellerName.VisitedLinkColor = System.Drawing.Color.DimGray;
			// 
			// TradeBuyerName
			// 
			this.TradeBuyerName.ActiveLinkColor = System.Drawing.Color.Black;
			this.TradeBuyerName.HeaderText = "Покупатель";
			this.TradeBuyerName.LinkColor = System.Drawing.Color.Black;
			this.TradeBuyerName.Name = "TradeBuyerName";
			this.TradeBuyerName.ReadOnly = true;
			this.TradeBuyerName.VisitedLinkColor = System.Drawing.Color.DimGray;
			// 
			// TradeQuantity
			// 
			this.TradeQuantity.HeaderText = "Кол-во";
			this.TradeQuantity.Name = "TradeQuantity";
			this.TradeQuantity.ReadOnly = true;
			this.TradeQuantity.Width = 47;
			// 
			// TradePrice
			// 
			this.TradePrice.HeaderText = "Цена";
			this.TradePrice.Name = "TradePrice";
			this.TradePrice.ReadOnly = true;
			this.TradePrice.Width = 40;
			// 
			// TradeDateTime
			// 
			this.TradeDateTime.HeaderText = "Время";
			this.TradeDateTime.Name = "TradeDateTime";
			this.TradeDateTime.ReadOnly = true;
			this.TradeDateTime.Width = 150;
			// 
			// TraderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 361);
			this.Controls.Add(this.TraderTabs);
			this.Controls.Add(this.TraderInfoGroupBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "TraderForm";
			this.Text = "Торговец - Торговая площадка";
			this.Load += new System.EventHandler(this.TraderForm_Load);
			this.TraderInfoGroupBox.ResumeLayout(false);
			this.TraderInfoGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TraderImage)).EndInit();
			this.TraderTabs.ResumeLayout(false);
			this.SellOffersTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SellOffersData)).EndInit();
			this.BuyOffersTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BuyOffersData)).EndInit();
			this.TradesTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.TradesData)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox TraderInfoGroupBox;
		private System.Windows.Forms.TextBox TraderDescriptionTextBox;
		private System.Windows.Forms.Label TraderNameLabel;
		private System.Windows.Forms.PictureBox TraderImage;
		private System.Windows.Forms.TabControl TraderTabs;
		private System.Windows.Forms.TabPage SellOffersTab;
		private System.Windows.Forms.TabPage BuyOffersTab;
		private System.Windows.Forms.Button BuyButton;
		private System.Windows.Forms.TabPage TradesTab;
		private System.Windows.Forms.DataGridView TradesData;
		private System.Windows.Forms.DataGridView SellOffersData;
		private System.Windows.Forms.DataGridViewTextBoxColumn SellItemID;
		private System.Windows.Forms.DataGridViewLinkColumn SellItemName;
		private System.Windows.Forms.DataGridViewTextBoxColumn SellItemQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn SellItemPrice;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BuyCheck;
		private System.Windows.Forms.DataGridViewTextBoxColumn BuyQuantity;
		private System.Windows.Forms.DataGridView BuyOffersData;
		private System.Windows.Forms.DataGridViewTextBoxColumn BuyItemID;
		private System.Windows.Forms.DataGridViewLinkColumn BuyItemName;
		private System.Windows.Forms.DataGridViewTextBoxColumn BuyItemQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn BuyItemPrice;
		private System.Windows.Forms.DataGridViewCheckBoxColumn SellCheck;
		private System.Windows.Forms.DataGridViewTextBoxColumn SellQuantity;
		private System.Windows.Forms.Button SellButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn TradeSellerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TradeBuyerID;
		private System.Windows.Forms.DataGridViewLinkColumn TradeSellerName;
		private System.Windows.Forms.DataGridViewLinkColumn TradeBuyerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn TradeQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn TradePrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn TradeDateTime;
	}
}