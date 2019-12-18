namespace InventoryManagementSystem
{
    partial class SaveAndExitDialog
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
            this.dialogSave = new System.Windows.Forms.Button();
            this.dialogCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dialogSave
            // 
            this.dialogSave.Location = new System.Drawing.Point(12, 95);
            this.dialogSave.Name = "dialogSave";
            this.dialogSave.Size = new System.Drawing.Size(75, 23);
            this.dialogSave.TabIndex = 0;
            this.dialogSave.Text = "Save";
            this.dialogSave.UseVisualStyleBackColor = true;
            this.dialogSave.Click += new System.EventHandler(this.dialogSave_Click);
            // 
            // dialogCancel
            // 
            this.dialogCancel.Location = new System.Drawing.Point(232, 95);
            this.dialogCancel.Name = "dialogCancel";
            this.dialogCancel.Size = new System.Drawing.Size(75, 23);
            this.dialogCancel.TabIndex = 0;
            this.dialogCancel.Text = "Cancel";
            this.dialogCancel.UseVisualStyleBackColor = true;
            this.dialogCancel.Click += new System.EventHandler(this.dialogCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Save the cart before exiting.";
            // 
            // SaveAndExitDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dialogCancel);
            this.Controls.Add(this.dialogSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SaveAndExitDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveAndExitDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dialogSave;
        private System.Windows.Forms.Button dialogCancel;
        private System.Windows.Forms.Label label1;
    }
}