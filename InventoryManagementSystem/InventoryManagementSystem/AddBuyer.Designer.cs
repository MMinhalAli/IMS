namespace InventoryManagementSystem
{
    partial class AddBuyer
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
            this.ADD = new System.Windows.Forms.Button();
            this.BuyerID = new System.Windows.Forms.TextBox();
            this.BuyerName = new System.Windows.Forms.TextBox();
            this.Retailer = new System.Windows.Forms.RadioButton();
            this.WholeSaller = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BuyerEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(161, 239);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(75, 23);
            this.ADD.TabIndex = 5;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // BuyerID
            // 
            this.BuyerID.Location = new System.Drawing.Point(133, 52);
            this.BuyerID.Name = "BuyerID";
            this.BuyerID.Size = new System.Drawing.Size(149, 20);
            this.BuyerID.TabIndex = 0;
            // 
            // BuyerName
            // 
            this.BuyerName.Location = new System.Drawing.Point(133, 103);
            this.BuyerName.Name = "BuyerName";
            this.BuyerName.Size = new System.Drawing.Size(149, 20);
            this.BuyerName.TabIndex = 1;
            // 
            // Retailer
            // 
            this.Retailer.AutoSize = true;
            this.Retailer.Location = new System.Drawing.Point(86, 193);
            this.Retailer.Name = "Retailer";
            this.Retailer.Size = new System.Drawing.Size(61, 17);
            this.Retailer.TabIndex = 3;
            this.Retailer.TabStop = true;
            this.Retailer.Text = "Retailer";
            this.Retailer.UseVisualStyleBackColor = true;
            // 
            // WholeSaller
            // 
            this.WholeSaller.AutoSize = true;
            this.WholeSaller.Location = new System.Drawing.Point(244, 193);
            this.WholeSaller.Name = "WholeSaller";
            this.WholeSaller.Size = new System.Drawing.Size(82, 17);
            this.WholeSaller.TabIndex = 4;
            this.WholeSaller.TabStop = true;
            this.WholeSaller.Text = "WholeSaller";
            this.WholeSaller.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "BuyerID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "BuyerName";
            // 
            // BuyerEmail
            // 
            this.BuyerEmail.Location = new System.Drawing.Point(133, 152);
            this.BuyerEmail.Name = "BuyerEmail";
            this.BuyerEmail.Size = new System.Drawing.Size(149, 20);
            this.BuyerEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // AddBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuyerEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WholeSaller);
            this.Controls.Add(this.Retailer);
            this.Controls.Add(this.BuyerName);
            this.Controls.Add(this.BuyerID);
            this.Controls.Add(this.ADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddBuyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBuyer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBuyer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox BuyerID;
        private System.Windows.Forms.TextBox BuyerName;
        private System.Windows.Forms.RadioButton Retailer;
        private System.Windows.Forms.RadioButton WholeSaller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BuyerEmail;
        private System.Windows.Forms.Label label3;
    }
}