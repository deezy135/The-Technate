namespace tm1
{
    partial class ItemForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
			this.ItemInfoGroupBox = new System.Windows.Forms.GroupBox();
			this.ItemDescriptionTextBox = new System.Windows.Forms.TextBox();
			this.ItemNameLabel = new System.Windows.Forms.Label();
			this.ItemImage = new System.Windows.Forms.PictureBox();
			this.SellOffersData = new System.Windows.Forms.DataGridView();
			this.SellItemRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SellerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SellerName = new System.Windows.Forms.DataGridViewLinkColumn();
			this.SellItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SellItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BuyCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.BuyQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemTabs = new System.Windows.Forms.TabControl();
			this.SellOffersTab = new System.Windows.Forms.TabPage();
			this.BuyRequestButton = new System.Windows.Forms.Button();
			this.BuyButton = new System.Windows.Forms.Button();
			this.BuyOffersTab = new System.Windows.Forms.TabPage();
			this.SellRequestButton = new System.Windows.Forms.Button();
			this.BuyOffersData = new System.Windows.Forms.DataGridView();
			this.BuyItemRequestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BuyerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BuyerName = new System.Windows.Forms.DataGridViewLinkColumn();
			this.BuyItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BuyItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SellCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.SellQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SellButton = new System.Windows.Forms.Button();
			this.TradesTab = new System.Windows.Forms.TabPage();
			this.TradesData = new System.Windows.Forms.DataGridView();
			this.TradeSellerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TradeBuyerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TradeSellerName = new System.Windows.Forms.DataGridViewLinkColumn();
			this.TradeBuyerName = new System.Windows.Forms.DataGridViewLinkColumn();
			this.TradeQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TradePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TradeDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemInfoGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SellOffersData)).BeginInit();
			this.ItemTabs.SuspendLayout();
			this.SellOffersTab.SuspendLayout();
			this.BuyOffersTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BuyOffersData)).BeginInit();
			this.TradesTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TradesData)).BeginInit();
			this.SuspendLayout();
			// 
			// ItemInfoGroupBox
			// 
			this.ItemInfoGroupBox.Controls.Add(this.ItemDescriptionTextBox);
			this.ItemInfoGroupBox.Controls.Add(this.ItemNameLabel);
			this.ItemInfoGroupBox.Controls.Add(this.ItemImage);
			this.ItemInfoGroupBox.Location = new System.Drawing.Point(12, 12);
			this.ItemInfoGroupBox.Name = "ItemInfoGroupBox";
			this.ItemInfoGroupBox.Size = new System.Drawing.Size(320, 100);
			this.ItemInfoGroupBox.TabIndex = 4;
			this.ItemInfoGroupBox.TabStop = false;
			this.ItemInfoGroupBox.Text = "Инф. о предмете";
			// 
			// ItemDescriptionTextBox
			// 
			this.ItemDescriptionTextBox.BackColor = System.Drawing.Color.White;
			this.ItemDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ItemDescriptionTextBox.Enabled = false;
			this.ItemDescriptionTextBox.Location = new System.Drawing.Point(76, 40);
			this.ItemDescriptionTextBox.Multiline = true;
			this.ItemDescriptionTextBox.Name = "ItemDescriptionTextBox";
			this.ItemDescriptionTextBox.ReadOnly = true;
			this.ItemDescriptionTextBox.Size = new System.Drawing.Size(170, 43);
			this.ItemDescriptionTextBox.TabIndex = 2;
			// 
			// ItemNameLabel
			// 
			this.ItemNameLabel.AutoSize = true;
			this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ItemNameLabel.Location = new System.Drawing.Point(76, 19);
			this.ItemNameLabel.Name = "ItemNameLabel";
			this.ItemNameLabel.Size = new System.Drawing.Size(126, 13);
			this.ItemNameLabel.TabIndex = 1;
			this.ItemNameLabel.Text = "Название предмета";
			// 
			// ItemImage
			// 
			this.ItemImage.Location = new System.Drawing.Point(6, 19);
			this.ItemImage.Name = "ItemImage";
			this.ItemImage.Size = new System.Drawing.Size(64, 64);
			this.ItemImage.TabIndex = 0;
			this.ItemImage.TabStop = false;
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
            this.SellItemRequestID,
            this.SellerID,
            this.SellerName,
            this.SellItemQuantity,
            this.SellItemPrice,
            this.BuyCheck,
            this.BuyQuantity});
			this.SellOffersData.Location = new System.Drawing.Point(6, 6);
			this.SellOffersData.Name = "SellOffersData";
			this.SellOffersData.RowHeadersVisible = false;
			this.SellOffersData.Size = new System.Drawing.Size(300, 160);
			this.SellOffersData.TabIndex = 0;
			this.SellOffersData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellOffersData_CellContentClick);
			// 
			// SellItemRequestID
			// 
			this.SellItemRequestID.HeaderText = "ID запроса";
			this.SellItemRequestID.Name = "SellItemRequestID";
			this.SellItemRequestID.Visible = false;
			// 
			// SellerID
			// 
			this.SellerID.HeaderText = "ID продавца";
			this.SellerID.Name = "SellerID";
			this.SellerID.ReadOnly = true;
			this.SellerID.Visible = false;
			// 
			// SellerName
			// 
			this.SellerName.ActiveLinkColor = System.Drawing.Color.Black;
			this.SellerName.HeaderText = "Продавец";
			this.SellerName.LinkColor = System.Drawing.Color.Black;
			this.SellerName.Name = "SellerName";
			this.SellerName.ReadOnly = true;
			this.SellerName.VisitedLinkColor = System.Drawing.Color.DimGray;
			this.SellerName.Width = 70;
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
			// ItemTabs
			// 
			this.ItemTabs.Controls.Add(this.SellOffersTab);
			this.ItemTabs.Controls.Add(this.BuyOffersTab);
			this.ItemTabs.Controls.Add(this.TradesTab);
			this.ItemTabs.Location = new System.Drawing.Point(12, 118);
			this.ItemTabs.Name = "ItemTabs";
			this.ItemTabs.SelectedIndex = 0;
			this.ItemTabs.Size = new System.Drawing.Size(320, 231);
			this.ItemTabs.TabIndex = 5;
			// 
			// SellOffersTab
			// 
			this.SellOffersTab.Controls.Add(this.BuyRequestButton);
			this.SellOffersTab.Controls.Add(this.BuyButton);
			this.SellOffersTab.Controls.Add(this.SellOffersData);
			this.SellOffersTab.Location = new System.Drawing.Point(4, 22);
			this.SellOffersTab.Name = "SellOffersTab";
			this.SellOffersTab.Padding = new System.Windows.Forms.Padding(3);
			this.SellOffersTab.Size = new System.Drawing.Size(312, 205);
			this.SellOffersTab.TabIndex = 1;
			this.SellOffersTab.Text = "На продажу";
			this.SellOffersTab.UseVisualStyleBackColor = true;
			// 
			// BuyRequestButton
			// 
			this.BuyRequestButton.Location = new System.Drawing.Point(6, 172);
			this.BuyRequestButton.Name = "BuyRequestButton";
			this.BuyRequestButton.Size = new System.Drawing.Size(136, 23);
			this.BuyRequestButton.TabIndex = 2;
			this.BuyRequestButton.Text = "Заказать предмет";
			this.BuyRequestButton.UseVisualStyleBackColor = true;
			this.BuyRequestButton.Click += new System.EventHandler(this.BuyRequestButton_Click);
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
			this.BuyOffersTab.Controls.Add(this.SellRequestButton);
			this.BuyOffersTab.Controls.Add(this.BuyOffersData);
			this.BuyOffersTab.Controls.Add(this.SellButton);
			this.BuyOffersTab.Location = new System.Drawing.Point(4, 22);
			this.BuyOffersTab.Name = "BuyOffersTab";
			this.BuyOffersTab.Padding = new System.Windows.Forms.Padding(3);
			this.BuyOffersTab.Size = new System.Drawing.Size(312, 205);
			this.BuyOffersTab.TabIndex = 0;
			this.BuyOffersTab.Text = "На покупку";
			this.BuyOffersTab.UseVisualStyleBackColor = true;
			// 
			// SellRequestButton
			// 
			this.SellRequestButton.Location = new System.Drawing.Point(6, 172);
			this.SellRequestButton.Name = "SellRequestButton";
			this.SellRequestButton.Size = new System.Drawing.Size(136, 23);
			this.SellRequestButton.TabIndex = 3;
			this.SellRequestButton.Text = "Выставить на продажу";
			this.SellRequestButton.UseVisualStyleBackColor = true;
			this.SellRequestButton.Click += new System.EventHandler(this.button1_Click);
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
            this.BuyItemRequestID,
            this.BuyerID,
            this.BuyerName,
            this.BuyItemQuantity,
            this.BuyItemPrice,
            this.SellCheck,
            this.SellQuantity});
			this.BuyOffersData.Location = new System.Drawing.Point(6, 6);
			this.BuyOffersData.Name = "BuyOffersData";
			this.BuyOffersData.RowHeadersVisible = false;
			this.BuyOffersData.Size = new System.Drawing.Size(300, 160);
			this.BuyOffersData.TabIndex = 2;
			// 
			// BuyItemRequestID
			// 
			this.BuyItemRequestID.HeaderText = "ID запроса";
			this.BuyItemRequestID.Name = "BuyItemRequestID";
			this.BuyItemRequestID.ReadOnly = true;
			this.BuyItemRequestID.Visible = false;
			// 
			// BuyerID
			// 
			this.BuyerID.HeaderText = "ID покупателя";
			this.BuyerID.Name = "BuyerID";
			this.BuyerID.ReadOnly = true;
			this.BuyerID.Visible = false;
			// 
			// BuyerName
			// 
			this.BuyerName.ActiveLinkColor = System.Drawing.Color.Black;
			this.BuyerName.HeaderText = "Покупатель";
			this.BuyerName.LinkColor = System.Drawing.Color.Black;
			this.BuyerName.Name = "BuyerName";
			this.BuyerName.ReadOnly = true;
			this.BuyerName.VisitedLinkColor = System.Drawing.Color.DimGray;
			this.BuyerName.Width = 70;
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
			this.SellCheck.Width = 20;
			// 
			// SellQuantity
			// 
			this.SellQuantity.HeaderText = "Продать (кол-во)";
			this.SellQuantity.Name = "SellQuantity";
			this.SellQuantity.Width = 117;
			// 
			// SellButton
			// 
			this.SellButton.Location = new System.Drawing.Point(231, 172);
			this.SellButton.Name = "SellButton";
			this.SellButton.Size = new System.Drawing.Size(75, 23);
			this.SellButton.TabIndex = 2;
			this.SellButton.Text = "Продать";
			this.SellButton.UseVisualStyleBackColor = true;
			this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
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
			this.TradesData.TabIndex = 3;
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
			this.TradeSellerName.Width = 75;
			// 
			// TradeBuyerName
			// 
			this.TradeBuyerName.ActiveLinkColor = System.Drawing.Color.Black;
			this.TradeBuyerName.HeaderText = "Покупатель";
			this.TradeBuyerName.LinkColor = System.Drawing.Color.Black;
			this.TradeBuyerName.Name = "TradeBuyerName";
			this.TradeBuyerName.ReadOnly = true;
			this.TradeBuyerName.VisitedLinkColor = System.Drawing.Color.DimGray;
			this.TradeBuyerName.Width = 75;
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
			// ItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 361);
			this.Controls.Add(this.ItemTabs);
			this.Controls.Add(this.ItemInfoGroupBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ItemForm";
			this.Text = "Предмет - Торговая площадка";
			this.ItemInfoGroupBox.ResumeLayout(false);
			this.ItemInfoGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SellOffersData)).EndInit();
			this.ItemTabs.ResumeLayout(false);
			this.SellOffersTab.ResumeLayout(false);
			this.BuyOffersTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BuyOffersData)).EndInit();
			this.TradesTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.TradesData)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.GroupBox ItemInfoGroupBox;
		private System.Windows.Forms.TextBox ItemDescriptionTextBox;
		private System.Windows.Forms.Label ItemNameLabel;
		private System.Windows.Forms.PictureBox ItemImage;
		private System.Windows.Forms.DataGridView SellOffersData;
		private System.Windows.Forms.TabControl ItemTabs;
		private System.Windows.Forms.TabPage SellOffersTab;
		private System.Windows.Forms.Button BuyButton;
		private System.Windows.Forms.TabPage BuyOffersTab;
		private System.Windows.Forms.DataGridView BuyOffersData;
		private System.Windows.Forms.Button SellButton;
		private System.Windows.Forms.TabPage TradesTab;
		private System.Windows.Forms.DataGridView TradesData;
		private System.Windows.Forms.DataGridViewTextBoxColumn SellItemRequestID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SellerID;
		private System.Windows.Forms.DataGridViewLinkColumn SellerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn SellItemQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn SellItemPrice;
		private System.Windows.Forms.DataGridViewCheckBoxColumn BuyCheck;
		private System.Windows.Forms.DataGridViewTextBoxColumn BuyQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn BuyItemRequestID;
		private System.Windows.Forms.DataGridViewTextBoxColumn BuyerID;
		private System.Windows.Forms.DataGridViewLinkColumn BuyerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn BuyItemQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn BuyItemPrice;
		private System.Windows.Forms.DataGridViewCheckBoxColumn SellCheck;
		private System.Windows.Forms.DataGridViewTextBoxColumn SellQuantity;
		private System.Windows.Forms.Button BuyRequestButton;
		private System.Windows.Forms.Button SellRequestButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn TradeSellerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TradeBuyerID;
		private System.Windows.Forms.DataGridViewLinkColumn TradeSellerName;
		private System.Windows.Forms.DataGridViewLinkColumn TradeBuyerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn TradeQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn TradePrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn TradeDateTime;
	}
}