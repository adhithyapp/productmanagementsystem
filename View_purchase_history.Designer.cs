namespace product_management
{
    partial class View_purchase_history
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
            this.ll_gotohome = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ll_gotohome
            // 
            this.ll_gotohome.AutoSize = true;
            this.ll_gotohome.Location = new System.Drawing.Point(193, 31);
            this.ll_gotohome.Name = "ll_gotohome";
            this.ll_gotohome.Size = new System.Drawing.Size(68, 13);
            this.ll_gotohome.TabIndex = 10;
            this.ll_gotohome.TabStop = true;
            this.ll_gotohome.Text = "Go To Home";
            this.ll_gotohome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_gotohome_LinkClicked);
            // 
            // View_purchase_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ll_gotohome);
            this.Name = "View_purchase_history";
            this.Text = "View_purchase_history";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_purchase_history_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_gotohome;
    }
}