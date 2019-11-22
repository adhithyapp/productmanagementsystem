namespace product_management
{
    partial class View_customer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ll_gotohome = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // ll_gotohome
            // 
            this.ll_gotohome.AutoSize = true;
            this.ll_gotohome.Location = new System.Drawing.Point(319, 28);
            this.ll_gotohome.Name = "ll_gotohome";
            this.ll_gotohome.Size = new System.Drawing.Size(68, 13);
            this.ll_gotohome.TabIndex = 10;
            this.ll_gotohome.TabStop = true;
            this.ll_gotohome.Text = "Go To Home";
            this.ll_gotohome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_gotohome_LinkClicked);
            // 
            // View_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 370);
            this.Controls.Add(this.ll_gotohome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_customer";
            this.Text = "View_customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_customer_FormClosing);
            this.Load += new System.EventHandler(this.View_customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel ll_gotohome;
    }
}