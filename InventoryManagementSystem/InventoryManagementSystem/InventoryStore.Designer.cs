namespace InventoryManagementSystem
{
    partial class InventoryStore
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
            //base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.AvaliableStock = new System.Windows.Forms.Button();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.UpdateItem = new System.Windows.Forms.Button();
            this.AddCompany = new System.Windows.Forms.Button();
            this.UpdateCompany = new System.Windows.Forms.Button();
            this.DeleteCompany = new System.Windows.Forms.Button();
            this.AddBuyer = new System.Windows.Forms.Button();
            this.UpdateBuyer = new System.Windows.Forms.Button();
            this.DeleteBuyer = new System.Windows.Forms.Button();
            this.showProviderInfo = new System.Windows.Forms.Button();
            this.showBuyerINfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.providerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.buyerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.ShowCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "                     Welcome to InventoryStore Form";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(67, 68);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 1;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItem_Click);
            // 
            // AvaliableStock
            // 
            this.AvaliableStock.Location = new System.Drawing.Point(151, 97);
            this.AvaliableStock.Name = "AvaliableStock";
            this.AvaliableStock.Size = new System.Drawing.Size(92, 23);
            this.AvaliableStock.TabIndex = 2;
            this.AvaliableStock.Text = "Avaliable Stock";
            this.AvaliableStock.UseVisualStyleBackColor = true;
            this.AvaliableStock.Click += new System.EventHandler(this.AvaliableStockBtn_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Location = new System.Drawing.Point(242, 68);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(75, 23);
            this.DeleteItem.TabIndex = 4;
            this.DeleteItem.Text = "Delete Item";
            this.DeleteItem.UseVisualStyleBackColor = true;
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItemBtn_Click);
            // 
            // UpdateItem
            // 
            this.UpdateItem.Location = new System.Drawing.Point(152, 68);
            this.UpdateItem.Name = "UpdateItem";
            this.UpdateItem.Size = new System.Drawing.Size(75, 23);
            this.UpdateItem.TabIndex = 5;
            this.UpdateItem.Text = "Update Item";
            this.UpdateItem.UseVisualStyleBackColor = true;
            this.UpdateItem.Click += new System.EventHandler(this.UpdateItemBtn_Click);
            // 
            // AddCompany
            // 
            this.AddCompany.Location = new System.Drawing.Point(323, 68);
            this.AddCompany.Name = "AddCompany";
            this.AddCompany.Size = new System.Drawing.Size(99, 23);
            this.AddCompany.TabIndex = 6;
            this.AddCompany.Text = "Add Company";
            this.AddCompany.UseVisualStyleBackColor = true;
            this.AddCompany.Click += new System.EventHandler(this.AddCompanyBtn_Click);
            // 
            // UpdateCompany
            // 
            this.UpdateCompany.Location = new System.Drawing.Point(428, 68);
            this.UpdateCompany.Name = "UpdateCompany";
            this.UpdateCompany.Size = new System.Drawing.Size(99, 23);
            this.UpdateCompany.TabIndex = 7;
            this.UpdateCompany.Text = "Update Company";
            this.UpdateCompany.UseVisualStyleBackColor = true;
            this.UpdateCompany.Click += new System.EventHandler(this.UpdateCompany_Click);
            // 
            // DeleteCompany
            // 
            this.DeleteCompany.Location = new System.Drawing.Point(533, 68);
            this.DeleteCompany.Name = "DeleteCompany";
            this.DeleteCompany.Size = new System.Drawing.Size(99, 23);
            this.DeleteCompany.TabIndex = 8;
            this.DeleteCompany.Text = "Delete Company";
            this.DeleteCompany.UseVisualStyleBackColor = true;
            this.DeleteCompany.Click += new System.EventHandler(this.DeleteCompany_Click);
            // 
            // AddBuyer
            // 
            this.AddBuyer.Location = new System.Drawing.Point(638, 68);
            this.AddBuyer.Name = "AddBuyer";
            this.AddBuyer.Size = new System.Drawing.Size(99, 23);
            this.AddBuyer.TabIndex = 9;
            this.AddBuyer.Text = "Add Buyer";
            this.AddBuyer.UseVisualStyleBackColor = true;
            this.AddBuyer.Click += new System.EventHandler(this.AddBuyer_Click);
            // 
            // UpdateBuyer
            // 
            this.UpdateBuyer.Location = new System.Drawing.Point(743, 68);
            this.UpdateBuyer.Name = "UpdateBuyer";
            this.UpdateBuyer.Size = new System.Drawing.Size(99, 23);
            this.UpdateBuyer.TabIndex = 10;
            this.UpdateBuyer.Text = "Update Buyer";
            this.UpdateBuyer.UseVisualStyleBackColor = true;
            this.UpdateBuyer.Click += new System.EventHandler(this.UpdateBuyer_Click);
            // 
            // DeleteBuyer
            // 
            this.DeleteBuyer.Location = new System.Drawing.Point(848, 68);
            this.DeleteBuyer.Name = "DeleteBuyer";
            this.DeleteBuyer.Size = new System.Drawing.Size(99, 23);
            this.DeleteBuyer.TabIndex = 11;
            this.DeleteBuyer.Text = "Delete Buyer";
            this.DeleteBuyer.UseVisualStyleBackColor = true;
            this.DeleteBuyer.Click += new System.EventHandler(this.DeleteBuyer_Click);
            // 
            // showProviderInfo
            // 
            this.showProviderInfo.Location = new System.Drawing.Point(475, 97);
            this.showProviderInfo.Name = "showProviderInfo";
            this.showProviderInfo.Size = new System.Drawing.Size(120, 23);
            this.showProviderInfo.TabIndex = 12;
            this.showProviderInfo.Text = "Available Providers";
            this.showProviderInfo.UseVisualStyleBackColor = true;
            this.showProviderInfo.Click += new System.EventHandler(this.showProviderInfo_Click);
            // 
            // showBuyerINfo
            // 
            this.showBuyerINfo.Location = new System.Drawing.Point(804, 97);
            this.showBuyerINfo.Name = "showBuyerINfo";
            this.showBuyerINfo.Size = new System.Drawing.Size(99, 23);
            this.showBuyerINfo.TabIndex = 13;
            this.showBuyerINfo.Text = "Available Buyers";
            this.showBuyerINfo.UseVisualStyleBackColor = true;
            this.showBuyerINfo.Click += new System.EventHandler(this.showBuyerINfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.itemName,
            this.cost,
            this.companyID,
            this.quantity});
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(386, 320);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // itemID
            // 
            this.itemID.HeaderText = "ItemID";
            this.itemID.Name = "itemID";
            this.itemID.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "ItemName";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // companyID
            // 
            this.companyID.HeaderText = "CompanyID";
            this.companyID.Name = "companyID";
            this.companyID.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.providerID,
            this.providerName});
            this.dataGridView2.Location = new System.Drawing.Point(415, 179);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(266, 320);
            this.dataGridView2.TabIndex = 15;
            // 
            // providerID
            // 
            this.providerID.HeaderText = "CompanyID";
            this.providerID.Name = "providerID";
            this.providerID.ReadOnly = true;
            // 
            // providerName
            // 
            this.providerName.HeaderText = "CompanyName";
            this.providerName.Name = "providerName";
            this.providerName.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "AVAILABLE STOCK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "AVAILABLE PROVIDER";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buyerID,
            this.buyerName,
            this.buyerType});
            this.dataGridView3.Location = new System.Drawing.Point(702, 179);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(297, 320);
            this.dataGridView3.TabIndex = 18;
            // 
            // buyerID
            // 
            this.buyerID.HeaderText = "BuyerID";
            this.buyerID.Name = "buyerID";
            this.buyerID.ReadOnly = true;
            // 
            // buyerName
            // 
            this.buyerName.HeaderText = "BuyerName";
            this.buyerName.Name = "buyerName";
            this.buyerName.ReadOnly = true;
            // 
            // buyerType
            // 
            this.buyerType.HeaderText = "BuyerType";
            this.buyerType.Name = "buyerType";
            this.buyerType.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(801, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "AVAILABLE BUYER";
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(682, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(99, 34);
            this.LogOut.TabIndex = 20;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // ShowCart
            // 
            this.ShowCart.Location = new System.Drawing.Point(151, 15);
            this.ShowCart.Name = "ShowCart";
            this.ShowCart.Size = new System.Drawing.Size(99, 34);
            this.ShowCart.TabIndex = 21;
            this.ShowCart.Text = "Show Cart";
            this.ShowCart.UseVisualStyleBackColor = true;
            this.ShowCart.Click += new System.EventHandler(this.ShowCart_Click);
            // 
            // InventoryStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 502);
            this.Controls.Add(this.ShowCart);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showBuyerINfo);
            this.Controls.Add(this.showProviderInfo);
            this.Controls.Add(this.DeleteBuyer);
            this.Controls.Add(this.UpdateBuyer);
            this.Controls.Add(this.AddBuyer);
            this.Controls.Add(this.DeleteCompany);
            this.Controls.Add(this.UpdateCompany);
            this.Controls.Add(this.AddCompany);
            this.Controls.Add(this.UpdateItem);
            this.Controls.Add(this.DeleteItem);
            this.Controls.Add(this.AvaliableStock);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "InventoryStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryStore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventoryStore_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button AvaliableStock;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.Button UpdateItem;
        private System.Windows.Forms.Button AddCompany;
        private System.Windows.Forms.Button UpdateCompany;
        private System.Windows.Forms.Button DeleteCompany;
        private System.Windows.Forms.Button AddBuyer;
        private System.Windows.Forms.Button UpdateBuyer;
        private System.Windows.Forms.Button DeleteBuyer;
        private System.Windows.Forms.Button showProviderInfo;
        private System.Windows.Forms.Button showBuyerINfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerName;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyerType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button ShowCart;
    }
}