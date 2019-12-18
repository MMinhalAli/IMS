namespace InventoryManagementSystem
{
    partial class CartForm
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
            this.displayItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AddToCart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.itemIDsComboBox = new System.Windows.Forms.ComboBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.CheckOut = new System.Windows.Forms.Button();
            this.invoiceNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.merchandiserId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalAmountTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.BuyerID = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displayItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // displayItemsDataGridView
            // 
            this.displayItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.displayItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemId,
            this.Qty,
            this.unitPrice,
            this.amount});
            this.displayItemsDataGridView.Location = new System.Drawing.Point(97, 201);
            this.displayItemsDataGridView.Name = "displayItemsDataGridView";
            this.displayItemsDataGridView.ReadOnly = true;
            this.displayItemsDataGridView.Size = new System.Drawing.Size(612, 233);
            this.displayItemsDataGridView.TabIndex = 1;
            // 
            // itemId
            // 
            this.itemId.HeaderText = "ItemID";
            this.itemId.Name = "itemId";
            this.itemId.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BuyerID";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(665, 94);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(97, 149);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(99, 30);
            this.AddToCart.TabIndex = 4;
            this.AddToCart.Text = "Add To Cart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ItemID";
            // 
            // itemIDsComboBox
            // 
            this.itemIDsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemIDsComboBox.FormattingEnabled = true;
            this.itemIDsComboBox.Location = new System.Drawing.Point(411, 93);
            this.itemIDsComboBox.Name = "itemIDsComboBox";
            this.itemIDsComboBox.Size = new System.Drawing.Size(155, 21);
            this.itemIDsComboBox.TabIndex = 5;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(604, 101);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(46, 13);
            this.Quantity.TabIndex = 7;
            this.Quantity.Text = "Quantity";
            // 
            // CheckOut
            // 
            this.CheckOut.Location = new System.Drawing.Point(259, 149);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(99, 30);
            this.CheckOut.TabIndex = 8;
            this.CheckOut.Text = "Check Out";
            this.CheckOut.UseVisualStyleBackColor = true;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // invoiceNumber
            // 
            this.invoiceNumber.Location = new System.Drawing.Point(191, 34);
            this.invoiceNumber.Name = "invoiceNumber";
            this.invoiceNumber.ReadOnly = true;
            this.invoiceNumber.Size = new System.Drawing.Size(56, 20);
            this.invoiceNumber.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Invoice Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Merchandiser Name";
            // 
            // merchandiserId
            // 
            this.merchandiserId.Location = new System.Drawing.Point(553, 30);
            this.merchandiserId.Name = "merchandiserId";
            this.merchandiserId.ReadOnly = true;
            this.merchandiserId.Size = new System.Drawing.Size(156, 20);
            this.merchandiserId.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Price";
            // 
            // totalAmountTxtBox
            // 
            this.totalAmountTxtBox.Location = new System.Drawing.Point(580, 448);
            this.totalAmountTxtBox.Name = "totalAmountTxtBox";
            this.totalAmountTxtBox.ReadOnly = true;
            this.totalAmountTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalAmountTxtBox.Size = new System.Drawing.Size(101, 20);
            this.totalAmountTxtBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "RS";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(607, 149);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(99, 30);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // BuyerID
            // 
            this.BuyerID.Location = new System.Drawing.Point(160, 94);
            this.BuyerID.Name = "BuyerID";
            this.BuyerID.ReadOnly = true;
            this.BuyerID.Size = new System.Drawing.Size(156, 20);
            this.BuyerID.TabIndex = 17;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(439, 149);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(99, 30);
            this.Save.TabIndex = 18;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 480);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.BuyerID);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalAmountTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.merchandiserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invoiceNumber);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemIDsComboBox);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayItemsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CartForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.displayItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView displayItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox itemIDsComboBox;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.TextBox invoiceNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox merchandiserId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalAmountTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox BuyerID;
        private System.Windows.Forms.Button Save;
    }
}