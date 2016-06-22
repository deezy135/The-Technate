namespace tm1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainFormTabs = new System.Windows.Forms.TabControl();
			this.ItemsTab = new System.Windows.Forms.TabPage();
			this.SearchItemData = new System.Windows.Forms.DataGridView();
			this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemImage = new System.Windows.Forms.DataGridViewImageColumn();
			this.ItemName = new System.Windows.Forms.DataGridViewLinkColumn();
			this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SearchItemButton = new System.Windows.Forms.Button();
			this.SearchItemLabel = new System.Windows.Forms.Label();
			this.SearchItemTextBox = new System.Windows.Forms.TextBox();
			this.TradersTab = new System.Windows.Forms.TabPage();
			this.SearchTraderButton = new System.Windows.Forms.Button();
			this.SearchTraderLabel = new System.Windows.Forms.Label();
			this.SearchTraderTextBox = new System.Windows.Forms.TextBox();
			this.SearchTraderData = new System.Windows.Forms.DataGridView();
			this.TraderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TraderImage = new System.Windows.Forms.DataGridViewImageColumn();
			this.TraderName = new System.Windows.Forms.DataGridViewLinkColumn();
			this.TraderTradesAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TraderMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InventoryTab = new System.Windows.Forms.TabPage();
			this.SearchInventoryItemLabel = new System.Windows.Forms.Label();
			this.SearchInventoryItemTextBox = new System.Windows.Forms.TextBox();
			this.SearchInventoryButton = new System.Windows.Forms.Button();
			this.SearchInventoryData = new System.Windows.Forms.DataGridView();
			this.InventoryItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InventoryItemImage = new System.Windows.Forms.DataGridViewImageColumn();
			this.InventoryItemName = new System.Windows.Forms.DataGridViewLinkColumn();
			this.InventoryItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserInfoGroupBox = new System.Windows.Forms.GroupBox();
			this.UserDescriptionTextBox = new System.Windows.Forms.TextBox();
			this.UserNameLabel = new System.Windows.Forms.Label();
			this.UserPictureBox = new System.Windows.Forms.PictureBox();
			this.MainFormTabs.SuspendLayout();
			this.ItemsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SearchItemData)).BeginInit();
			this.TradersTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SearchTraderData)).BeginInit();
			this.InventoryTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SearchInventoryData)).BeginInit();
			this.UserInfoGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// MainFormTabs
			// 
			this.MainFormTabs.Controls.Add(this.ItemsTab);
			this.MainFormTabs.Controls.Add(this.TradersTab);
			this.MainFormTabs.Controls.Add(this.InventoryTab);
			this.MainFormTabs.Location = new System.Drawing.Point(12, 109);
			this.MainFormTabs.Name = "MainFormTabs";
			this.MainFormTabs.SelectedIndex = 0;
			this.MainFormTabs.Size = new System.Drawing.Size(440, 268);
			this.MainFormTabs.TabIndex = 0;
			// 
			// ItemsTab
			// 
			this.ItemsTab.Controls.Add(this.SearchItemData);
			this.ItemsTab.Controls.Add(this.SearchItemButton);
			this.ItemsTab.Controls.Add(this.SearchItemLabel);
			this.ItemsTab.Controls.Add(this.SearchItemTextBox);
			this.ItemsTab.Location = new System.Drawing.Point(4, 22);
			this.ItemsTab.Name = "ItemsTab";
			this.ItemsTab.Padding = new System.Windows.Forms.Padding(3);
			this.ItemsTab.Size = new System.Drawing.Size(432, 242);
			this.ItemsTab.TabIndex = 0;
			this.ItemsTab.Text = "Предметы";
			this.ItemsTab.UseVisualStyleBackColor = true;
			// 
			// SearchItemData
			// 
			this.SearchItemData.AllowUserToAddRows = false;
			this.SearchItemData.AllowUserToDeleteRows = false;
			this.SearchItemData.AllowUserToResizeColumns = false;
			this.SearchItemData.AllowUserToResizeRows = false;
			this.SearchItemData.BackgroundColor = System.Drawing.Color.White;
			this.SearchItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SearchItemData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.ItemImage,
            this.ItemName,
            this.ItemQuantity,
            this.ItemPrice});
			this.SearchItemData.Location = new System.Drawing.Point(6, 46);
			this.SearchItemData.MultiSelect = false;
			this.SearchItemData.Name = "SearchItemData";
			this.SearchItemData.ReadOnly = true;
			this.SearchItemData.RowHeadersVisible = false;
			this.SearchItemData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.SearchItemData.RowTemplate.Height = 50;
			this.SearchItemData.Size = new System.Drawing.Size(420, 190);
			this.SearchItemData.TabIndex = 3;
			this.SearchItemData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchItemData_CellContentClick);
			// 
			// itemID
			// 
			this.itemID.Frozen = true;
			this.itemID.HeaderText = "ID предмета";
			this.itemID.Name = "itemID";
			this.itemID.ReadOnly = true;
			this.itemID.Visible = false;
			// 
			// ItemImage
			// 
			this.ItemImage.Frozen = true;
			this.ItemImage.HeaderText = "";
			this.ItemImage.Name = "ItemImage";
			this.ItemImage.ReadOnly = true;
			this.ItemImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ItemImage.Width = 50;
			// 
			// ItemName
			// 
			this.ItemName.ActiveLinkColor = System.Drawing.Color.Black;
			this.ItemName.Frozen = true;
			this.ItemName.HeaderText = "Название";
			this.ItemName.LinkColor = System.Drawing.Color.Black;
			this.ItemName.Name = "ItemName";
			this.ItemName.ReadOnly = true;
			this.ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ItemName.VisitedLinkColor = System.Drawing.Color.DimGray;
			this.ItemName.Width = 250;
			// 
			// ItemQuantity
			// 
			this.ItemQuantity.Frozen = true;
			this.ItemQuantity.HeaderText = "Кол-во";
			this.ItemQuantity.Name = "ItemQuantity";
			this.ItemQuantity.ReadOnly = true;
			this.ItemQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ItemQuantity.Width = 60;
			// 
			// ItemPrice
			// 
			this.ItemPrice.Frozen = true;
			this.ItemPrice.HeaderText = "Цена";
			this.ItemPrice.Name = "ItemPrice";
			this.ItemPrice.ReadOnly = true;
			this.ItemPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ItemPrice.Width = 50;
			// 
			// SearchItemButton
			// 
			this.SearchItemButton.Location = new System.Drawing.Point(351, 17);
			this.SearchItemButton.Name = "SearchItemButton";
			this.SearchItemButton.Size = new System.Drawing.Size(75, 23);
			this.SearchItemButton.TabIndex = 2;
			this.SearchItemButton.Text = "Поиск";
			this.SearchItemButton.UseVisualStyleBackColor = true;
			this.SearchItemButton.Click += new System.EventHandler(this.SearchItemButton_Click);
			// 
			// SearchItemLabel
			// 
			this.SearchItemLabel.AutoSize = true;
			this.SearchItemLabel.Location = new System.Drawing.Point(6, 3);
			this.SearchItemLabel.Name = "SearchItemLabel";
			this.SearchItemLabel.Size = new System.Drawing.Size(60, 13);
			this.SearchItemLabel.TabIndex = 1;
			this.SearchItemLabel.Text = "Название:";
			// 
			// SearchItemTextBox
			// 
			this.SearchItemTextBox.Location = new System.Drawing.Point(6, 19);
			this.SearchItemTextBox.Name = "SearchItemTextBox";
			this.SearchItemTextBox.Size = new System.Drawing.Size(339, 20);
			this.SearchItemTextBox.TabIndex = 0;
			this.SearchItemTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchItemTextBox_KeyDown);
			// 
			// TradersTab
			// 
			this.TradersTab.Controls.Add(this.SearchTraderButton);
			this.TradersTab.Controls.Add(this.SearchTraderLabel);
			this.TradersTab.Controls.Add(this.SearchTraderTextBox);
			this.TradersTab.Controls.Add(this.SearchTraderData);
			this.TradersTab.Location = new System.Drawing.Point(4, 22);
			this.TradersTab.Name = "TradersTab";
			this.TradersTab.Padding = new System.Windows.Forms.Padding(3);
			this.TradersTab.Size = new System.Drawing.Size(432, 242);
			this.TradersTab.TabIndex = 1;
			this.TradersTab.Text = "Торговцы";
			this.TradersTab.UseVisualStyleBackColor = true;
			// 
			// SearchTraderButton
			// 
			this.SearchTraderButton.Location = new System.Drawing.Point(351, 17);
			this.SearchTraderButton.Name = "SearchTraderButton";
			this.SearchTraderButton.Size = new System.Drawing.Size(75, 23);
			this.SearchTraderButton.TabIndex = 5;
			this.SearchTraderButton.Text = "Поиск";
			this.SearchTraderButton.UseVisualStyleBackColor = true;
			this.SearchTraderButton.Click += new System.EventHandler(this.SearchTraderButton_Click);
			// 
			// SearchTraderLabel
			// 
			this.SearchTraderLabel.AutoSize = true;
			this.SearchTraderLabel.Location = new System.Drawing.Point(6, 3);
			this.SearchTraderLabel.Name = "SearchTraderLabel";
			this.SearchTraderLabel.Size = new System.Drawing.Size(32, 13);
			this.SearchTraderLabel.TabIndex = 4;
			this.SearchTraderLabel.Text = "Имя:";
			// 
			// SearchTraderTextBox
			// 
			this.SearchTraderTextBox.Location = new System.Drawing.Point(6, 19);
			this.SearchTraderTextBox.Name = "SearchTraderTextBox";
			this.SearchTraderTextBox.Size = new System.Drawing.Size(339, 20);
			this.SearchTraderTextBox.TabIndex = 3;
			this.SearchTraderTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTraderTextBox_KeyDown);
			// 
			// SearchTraderData
			// 
			this.SearchTraderData.AllowUserToAddRows = false;
			this.SearchTraderData.AllowUserToDeleteRows = false;
			this.SearchTraderData.AllowUserToResizeColumns = false;
			this.SearchTraderData.AllowUserToResizeRows = false;
			this.SearchTraderData.BackgroundColor = System.Drawing.Color.White;
			this.SearchTraderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SearchTraderData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TraderID,
            this.TraderImage,
            this.TraderName,
            this.TraderTradesAmount,
            this.TraderMoney});
			this.SearchTraderData.Location = new System.Drawing.Point(6, 46);
			this.SearchTraderData.Name = "SearchTraderData";
			this.SearchTraderData.ReadOnly = true;
			this.SearchTraderData.RowHeadersVisible = false;
			this.SearchTraderData.RowTemplate.Height = 50;
			this.SearchTraderData.Size = new System.Drawing.Size(420, 190);
			this.SearchTraderData.TabIndex = 0;
			this.SearchTraderData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchTradersData_CellContentClick);
			// 
			// TraderID
			// 
			this.TraderID.Frozen = true;
			this.TraderID.HeaderText = "ID торговца";
			this.TraderID.Name = "TraderID";
			this.TraderID.ReadOnly = true;
			this.TraderID.Visible = false;
			this.TraderID.Width = 105;
			// 
			// TraderImage
			// 
			this.TraderImage.HeaderText = "";
			this.TraderImage.Name = "TraderImage";
			this.TraderImage.ReadOnly = true;
			this.TraderImage.Width = 50;
			// 
			// TraderName
			// 
			this.TraderName.ActiveLinkColor = System.Drawing.Color.Black;
			this.TraderName.HeaderText = "Имя";
			this.TraderName.LinkColor = System.Drawing.Color.Black;
			this.TraderName.Name = "TraderName";
			this.TraderName.ReadOnly = true;
			this.TraderName.VisitedLinkColor = System.Drawing.Color.DimGray;
			this.TraderName.Width = 175;
			// 
			// TraderTradesAmount
			// 
			this.TraderTradesAmount.HeaderText = "Кол-во сделок";
			this.TraderTradesAmount.Name = "TraderTradesAmount";
			this.TraderTradesAmount.ReadOnly = true;
			this.TraderTradesAmount.Width = 105;
			// 
			// TraderMoney
			// 
			this.TraderMoney.HeaderText = "Сумма";
			this.TraderMoney.Name = "TraderMoney";
			this.TraderMoney.ReadOnly = true;
			this.TraderMoney.Width = 60;
			// 
			// InventoryTab
			// 
			this.InventoryTab.Controls.Add(this.SearchInventoryItemLabel);
			this.InventoryTab.Controls.Add(this.SearchInventoryItemTextBox);
			this.InventoryTab.Controls.Add(this.SearchInventoryButton);
			this.InventoryTab.Controls.Add(this.SearchInventoryData);
			this.InventoryTab.Location = new System.Drawing.Point(4, 22);
			this.InventoryTab.Name = "InventoryTab";
			this.InventoryTab.Padding = new System.Windows.Forms.Padding(3);
			this.InventoryTab.Size = new System.Drawing.Size(432, 242);
			this.InventoryTab.TabIndex = 2;
			this.InventoryTab.Text = "Инвентарь";
			this.InventoryTab.UseVisualStyleBackColor = true;
			// 
			// SearchInventoryItemLabel
			// 
			this.SearchInventoryItemLabel.AutoSize = true;
			this.SearchInventoryItemLabel.Location = new System.Drawing.Point(6, 3);
			this.SearchInventoryItemLabel.Name = "SearchInventoryItemLabel";
			this.SearchInventoryItemLabel.Size = new System.Drawing.Size(60, 13);
			this.SearchInventoryItemLabel.TabIndex = 9;
			this.SearchInventoryItemLabel.Text = "Название:";
			// 
			// SearchInventoryItemTextBox
			// 
			this.SearchInventoryItemTextBox.Location = new System.Drawing.Point(6, 19);
			this.SearchInventoryItemTextBox.Name = "SearchInventoryItemTextBox";
			this.SearchInventoryItemTextBox.Size = new System.Drawing.Size(339, 20);
			this.SearchInventoryItemTextBox.TabIndex = 8;
			// 
			// SearchInventoryButton
			// 
			this.SearchInventoryButton.Location = new System.Drawing.Point(351, 17);
			this.SearchInventoryButton.Name = "SearchInventoryButton";
			this.SearchInventoryButton.Size = new System.Drawing.Size(75, 23);
			this.SearchInventoryButton.TabIndex = 6;
			this.SearchInventoryButton.Text = "Поиск";
			this.SearchInventoryButton.UseVisualStyleBackColor = true;
			this.SearchInventoryButton.Click += new System.EventHandler(this.SearchInventoryButton_Click);
			// 
			// SearchInventoryData
			// 
			this.SearchInventoryData.AllowUserToAddRows = false;
			this.SearchInventoryData.AllowUserToDeleteRows = false;
			this.SearchInventoryData.AllowUserToResizeColumns = false;
			this.SearchInventoryData.AllowUserToResizeRows = false;
			this.SearchInventoryData.BackgroundColor = System.Drawing.Color.White;
			this.SearchInventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SearchInventoryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventoryItemID,
            this.InventoryItemImage,
            this.InventoryItemName,
            this.InventoryItemQuantity});
			this.SearchInventoryData.Location = new System.Drawing.Point(6, 46);
			this.SearchInventoryData.Name = "SearchInventoryData";
			this.SearchInventoryData.RowHeadersVisible = false;
			this.SearchInventoryData.RowTemplate.Height = 50;
			this.SearchInventoryData.Size = new System.Drawing.Size(420, 190);
			this.SearchInventoryData.TabIndex = 0;
			this.SearchInventoryData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchInventoryData_CellContentClick);
			// 
			// InventoryItemID
			// 
			this.InventoryItemID.HeaderText = "ID предмета инвентаря";
			this.InventoryItemID.Name = "InventoryItemID";
			this.InventoryItemID.ReadOnly = true;
			this.InventoryItemID.Visible = false;
			// 
			// InventoryItemImage
			// 
			this.InventoryItemImage.HeaderText = "";
			this.InventoryItemImage.Name = "InventoryItemImage";
			this.InventoryItemImage.ReadOnly = true;
			this.InventoryItemImage.Width = 50;
			// 
			// InventoryItemName
			// 
			this.InventoryItemName.ActiveLinkColor = System.Drawing.Color.Black;
			this.InventoryItemName.HeaderText = "Название";
			this.InventoryItemName.LinkColor = System.Drawing.Color.Black;
			this.InventoryItemName.Name = "InventoryItemName";
			this.InventoryItemName.ReadOnly = true;
			this.InventoryItemName.VisitedLinkColor = System.Drawing.Color.DimGray;
			this.InventoryItemName.Width = 250;
			// 
			// InventoryItemQuantity
			// 
			this.InventoryItemQuantity.HeaderText = "Кол-во";
			this.InventoryItemQuantity.Name = "InventoryItemQuantity";
			this.InventoryItemQuantity.ReadOnly = true;
			this.InventoryItemQuantity.Width = 60;
			// 
			// UserInfoGroupBox
			// 
			this.UserInfoGroupBox.Controls.Add(this.UserDescriptionTextBox);
			this.UserInfoGroupBox.Controls.Add(this.UserNameLabel);
			this.UserInfoGroupBox.Controls.Add(this.UserPictureBox);
			this.UserInfoGroupBox.Location = new System.Drawing.Point(12, 12);
			this.UserInfoGroupBox.Name = "UserInfoGroupBox";
			this.UserInfoGroupBox.Size = new System.Drawing.Size(440, 91);
			this.UserInfoGroupBox.TabIndex = 1;
			this.UserInfoGroupBox.TabStop = false;
			this.UserInfoGroupBox.Text = "Профиль";
			// 
			// UserDescriptionTextBox
			// 
			this.UserDescriptionTextBox.BackColor = System.Drawing.Color.White;
			this.UserDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.UserDescriptionTextBox.Enabled = false;
			this.UserDescriptionTextBox.Location = new System.Drawing.Point(76, 40);
			this.UserDescriptionTextBox.Multiline = true;
			this.UserDescriptionTextBox.Name = "UserDescriptionTextBox";
			this.UserDescriptionTextBox.ReadOnly = true;
			this.UserDescriptionTextBox.Size = new System.Drawing.Size(170, 43);
			this.UserDescriptionTextBox.TabIndex = 3;
			// 
			// UserNameLabel
			// 
			this.UserNameLabel.AutoSize = true;
			this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserNameLabel.Location = new System.Drawing.Point(76, 19);
			this.UserNameLabel.Name = "UserNameLabel";
			this.UserNameLabel.Size = new System.Drawing.Size(32, 13);
			this.UserNameLabel.TabIndex = 2;
			this.UserNameLabel.Text = "Имя";
			// 
			// UserPictureBox
			// 
			this.UserPictureBox.Location = new System.Drawing.Point(6, 19);
			this.UserPictureBox.Name = "UserPictureBox";
			this.UserPictureBox.Size = new System.Drawing.Size(64, 64);
			this.UserPictureBox.TabIndex = 0;
			this.UserPictureBox.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 386);
			this.Controls.Add(this.UserInfoGroupBox);
			this.Controls.Add(this.MainFormTabs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Торговая площадка";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.MainFormTabs.ResumeLayout(false);
			this.ItemsTab.ResumeLayout(false);
			this.ItemsTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SearchItemData)).EndInit();
			this.TradersTab.ResumeLayout(false);
			this.TradersTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SearchTraderData)).EndInit();
			this.InventoryTab.ResumeLayout(false);
			this.InventoryTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SearchInventoryData)).EndInit();
			this.UserInfoGroupBox.ResumeLayout(false);
			this.UserInfoGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainFormTabs;
        private System.Windows.Forms.TabPage ItemsTab;
        private System.Windows.Forms.DataGridView SearchItemData;
        private System.Windows.Forms.Button SearchItemButton;
        private System.Windows.Forms.Label SearchItemLabel;
        private System.Windows.Forms.TextBox SearchItemTextBox;
        private System.Windows.Forms.TabPage TradersTab;
        private System.Windows.Forms.TabPage InventoryTab;
        private System.Windows.Forms.DataGridView SearchTraderData;
        private System.Windows.Forms.Button SearchTraderButton;
        private System.Windows.Forms.Label SearchTraderLabel;
        private System.Windows.Forms.TextBox SearchTraderTextBox;
        private System.Windows.Forms.Button SearchInventoryButton;
        private System.Windows.Forms.DataGridView SearchInventoryData;
		private System.Windows.Forms.Label SearchInventoryItemLabel;
		private System.Windows.Forms.TextBox SearchInventoryItemTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn InventoryItemID;
		private System.Windows.Forms.DataGridViewImageColumn InventoryItemImage;
		private System.Windows.Forms.DataGridViewLinkColumn InventoryItemName;
		private System.Windows.Forms.DataGridViewTextBoxColumn InventoryItemQuantity;
		private System.Windows.Forms.GroupBox UserInfoGroupBox;
		private System.Windows.Forms.PictureBox UserPictureBox;
		private System.Windows.Forms.Label UserNameLabel;
		private System.Windows.Forms.TextBox UserDescriptionTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
		private System.Windows.Forms.DataGridViewImageColumn ItemImage;
		private System.Windows.Forms.DataGridViewLinkColumn ItemName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn TraderID;
		private System.Windows.Forms.DataGridViewImageColumn TraderImage;
		private System.Windows.Forms.DataGridViewLinkColumn TraderName;
		private System.Windows.Forms.DataGridViewTextBoxColumn TraderTradesAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn TraderMoney;
	}
}

