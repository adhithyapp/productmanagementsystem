namespace product_management
{
    partial class Add_product
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
            this.components = new System.ComponentModel.Container();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_productname = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.ll_gotohome = new System.Windows.Forms.LinkLabel();
            this.product_ManagementDataSet = new product_management.Product_ManagementDataSet();
            this.tbladdcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_addcategoryTableAdapter = new product_management.Product_ManagementDataSetTableAdapters.tbl_addcategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.product_ManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdcategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(25, 70);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(49, 13);
            this.lbl_category.TabIndex = 0;
            this.lbl_category.Text = "Category";
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Location = new System.Drawing.Point(25, 124);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(75, 13);
            this.lbl_productname.TabIndex = 1;
            this.lbl_productname.Text = "Product Name";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(25, 181);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(31, 13);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "Price";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(25, 239);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(46, 13);
            this.lbl_quantity.TabIndex = 3;
            this.lbl_quantity.Text = "Quantity";
            // 
            // cmb_category
            // 
            this.cmb_category.DataSource = this.tbladdcategoryBindingSource;
            this.cmb_category.DisplayMember = "category";
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Location = new System.Drawing.Point(136, 67);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(149, 21);
            this.cmb_category.TabIndex = 4;
            this.cmb_category.ValueMember = "category";
            // 
            // txt_productname
            // 
            this.txt_productname.Location = new System.Drawing.Point(136, 124);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(149, 20);
            this.txt_productname.TabIndex = 5;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(136, 178);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(149, 20);
            this.txt_price.TabIndex = 6;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(136, 236);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(149, 20);
            this.txt_quantity.TabIndex = 7;
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.Location = new System.Drawing.Point(136, 295);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(75, 23);
            this.btn_addproduct.TabIndex = 8;
            this.btn_addproduct.Text = "ADD";
            this.btn_addproduct.UseVisualStyleBackColor = true;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // ll_gotohome
            // 
            this.ll_gotohome.AutoSize = true;
            this.ll_gotohome.Location = new System.Drawing.Point(241, 20);
            this.ll_gotohome.Name = "ll_gotohome";
            this.ll_gotohome.Size = new System.Drawing.Size(68, 13);
            this.ll_gotohome.TabIndex = 9;
            this.ll_gotohome.TabStop = true;
            this.ll_gotohome.Text = "Go To Home";
            this.ll_gotohome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_gotohome_LinkClicked);
            // 
            // product_ManagementDataSet
            // 
            this.product_ManagementDataSet.DataSetName = "Product_ManagementDataSet";
            this.product_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbladdcategoryBindingSource
            // 
            this.tbladdcategoryBindingSource.DataMember = "tbl_addcategory";
            this.tbladdcategoryBindingSource.DataSource = this.product_ManagementDataSet;
            // 
            // tbl_addcategoryTableAdapter
            // 
            this.tbl_addcategoryTableAdapter.ClearBeforeFill = true;
            // 
            // Add_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 380);
            this.Controls.Add(this.ll_gotohome);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_productname);
            this.Controls.Add(this.lbl_category);
            this.Name = "Add_product";
            this.Text = "Add_product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_product_FormClosing);
            this.Load += new System.EventHandler(this.Add_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_ManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdcategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_productname;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.LinkLabel ll_gotohome;
        private Product_ManagementDataSet product_ManagementDataSet;
        private System.Windows.Forms.BindingSource tbladdcategoryBindingSource;
        private Product_ManagementDataSetTableAdapters.tbl_addcategoryTableAdapter tbl_addcategoryTableAdapter;
    }
}