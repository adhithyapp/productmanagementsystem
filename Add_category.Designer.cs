namespace product_management
{
    partial class Add_category
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
            this.lbl_category = new System.Windows.Forms.Label();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.btn_addcategory = new System.Windows.Forms.Button();
            this.ll_gotohome = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(36, 95);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(49, 13);
            this.lbl_category.TabIndex = 0;
            this.lbl_category.Text = "Category";
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(120, 92);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(160, 20);
            this.txt_category.TabIndex = 1;
            // 
            // btn_addcategory
            // 
            this.btn_addcategory.Location = new System.Drawing.Point(120, 160);
            this.btn_addcategory.Name = "btn_addcategory";
            this.btn_addcategory.Size = new System.Drawing.Size(75, 23);
            this.btn_addcategory.TabIndex = 2;
            this.btn_addcategory.Text = "ADD";
            this.btn_addcategory.UseVisualStyleBackColor = true;
            this.btn_addcategory.Click += new System.EventHandler(this.btn_addcategory_Click);
            // 
            // ll_gotohome
            // 
            this.ll_gotohome.AutoSize = true;
            this.ll_gotohome.Location = new System.Drawing.Point(225, 35);
            this.ll_gotohome.Name = "ll_gotohome";
            this.ll_gotohome.Size = new System.Drawing.Size(68, 13);
            this.ll_gotohome.TabIndex = 3;
            this.ll_gotohome.TabStop = true;
            this.ll_gotohome.Text = "Go To Home";
            this.ll_gotohome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_gotohome_LinkClicked);
            // 
            // Add_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 285);
            this.Controls.Add(this.ll_gotohome);
            this.Controls.Add(this.btn_addcategory);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.lbl_category);
            this.Name = "Add_category";
            this.Text = "Add_category";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_category_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Button btn_addcategory;
        private System.Windows.Forms.LinkLabel ll_gotohome;
    }
}