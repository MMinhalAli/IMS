namespace InventoryManagementSystem
{
    partial class AddItems
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
            this.ItemID = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.RetailerProfitPrice = new System.Windows.Forms.TextBox();
            this.WholeSallerProfitPrice = new System.Windows.Forms.TextBox();
            this.CompanyID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemID
            // 
            this.ItemID.Location = new System.Drawing.Point(148, 34);
            this.ItemID.Name = "ItemID";
            this.ItemID.Size = new System.Drawing.Size(155, 20);
            this.ItemID.TabIndex = 0;
            
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(179, 315);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ItemName
            // 
            this.ItemName.Location = new System.Drawing.Point(148, 72);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(155, 20);
            this.ItemName.TabIndex = 1;
            
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(148, 112);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(155, 20);
            this.Cost.TabIndex = 2;
            
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(148, 189);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(155, 20);
            this.Quantity.TabIndex = 4;
            
            // 
            // RetailerProfitPrice
            // 
            this.RetailerProfitPrice.Location = new System.Drawing.Point(148, 227);
            this.RetailerProfitPrice.Name = "RetailerProfitPrice";
            this.RetailerProfitPrice.Size = new System.Drawing.Size(155, 20);
            this.RetailerProfitPrice.TabIndex = 5;
            
            // 
            // WholeSallerProfitPrice
            // 
            this.WholeSallerProfitPrice.Location = new System.Drawing.Point(147, 267);
            this.WholeSallerProfitPrice.Name = "WholeSallerProfitPrice";
            this.WholeSallerProfitPrice.Size = new System.Drawing.Size(155, 20);
            this.WholeSallerProfitPrice.TabIndex = 6;
            
            // 
            // CompanyID
            // 
            this.CompanyID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CompanyID.FormattingEnabled = true;
            this.CompanyID.Location = new System.Drawing.Point(147, 152);
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.Size = new System.Drawing.Size(156, 21);
            this.CompanyID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ItemID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ItemName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CompanyID\'s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "RetailerProfitPrice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "WholeSallerProfitPrice";
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 362);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CompanyID);
            this.Controls.Add(this.WholeSallerProfitPrice);
            this.Controls.Add(this.RetailerProfitPrice);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ItemID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItems";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddItems_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemID;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox RetailerProfitPrice;
        private System.Windows.Forms.TextBox WholeSallerProfitPrice;
        private System.Windows.Forms.ComboBox CompanyID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}