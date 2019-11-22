namespace product_management
{
    partial class Purchase_product
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
            this.btn_purchase = new System.Windows.Forms.Button();
            this.lbl_product = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_totalcost = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_totalcost = new System.Windows.Forms.TextBox();
            this.cmb_product = new System.Windows.Forms.ComboBox();
            this.tbladdproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_ManagementDataSet1 = new product_management.Product_ManagementDataSet1();
            this.lbl_errorqty = new System.Windows.Forms.Label();
            this.tbl_addproductTableAdapter = new product_management.Product_ManagementDataSet1TableAdapters.tbl_addproductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_ManagementDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_purchase
            // 
            this.btn_purchase.Location = new System.Drawing.Point(119, 277);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(75, 23);
            this.btn_purchase.TabIndex = 0;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.UseVisualStyleBackColor = true;
            this.btn_purchase.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(21, 52);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(44, 13);
            this.lbl_product.TabIndex = 1;
            this.lbl_product.Text = "Product";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(21, 109);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(31, 13);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "Price";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(21, 162);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(46, 13);
            this.lbl_quantity.TabIndex = 3;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_totalcost
            // 
            this.lbl_totalcost.AutoSize = true;
            this.lbl_totalcost.Location = new System.Drawing.Point(21, 214);
            this.lbl_totalcost.Name = "lbl_totalcost";
            this.lbl_totalcost.Size = new System.Drawing.Size(55, 13);
            this.lbl_totalcost.TabIndex = 4;
            this.lbl_totalcost.Text = "Total Cost";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(119, 106);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(170, 20);
            this.txt_price.TabIndex = 5;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(119, 159);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(170, 20);
            this.txt_quantity.TabIndex = 6;
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            // 
            // txt_totalcost
            // 
            this.txt_totalcost.Location = new System.Drawing.Point(119, 211);
            this.txt_totalcost.Name = "txt_totalcost";
            this.txt_totalcost.Size = new System.Drawing.Size(170, 20);
            this.txt_totalcost.TabIndex = 7;
            // 
            // cmb_product
            // 
            this.cmb_product.DataSource = this.tbladdproductBindingSource;
            this.cmb_product.DisplayMember = "productname";
            this.cmb_product.FormattingEnabled = true;
            this.cmb_product.Location = new System.Drawing.Point(119, 52);
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(170, 21);
            this.cmb_product.TabIndex = 8;
            this.cmb_product.ValueMember = "productname";
            this.cmb_product.SelectedIndexChanged += new System.EventHandler(this.cmb_product_SelectedIndexChanged);
            // 
            // tbladdproductBindingSource
            // 
            this.tbladdproductBindingSource.DataMember = "tbl_addproduct";
            this.tbladdproductBindingSource.DataSource = this.product_ManagementDataSet1;
            // 
            // product_ManagementDataSet1
            // 
            this.product_ManagementDataSet1.DataSetName = "Product_ManagementDataSet1";
            this.product_ManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_errorqty
            // 
            this.lbl_errorqty.AutoSize = true;
            this.lbl_errorqty.Location = new System.Drawing.Point(312, 166);
            this.lbl_errorqty.Name = "lbl_errorqty";
            this.lbl_errorqty.Size = new System.Drawing.Size(0, 13);
            this.lbl_errorqty.TabIndex = 9;
            // 
            // tbl_addproductTableAdapter
            // 
            this.tbl_addproductTableAdapter.ClearBeforeFill = true;
            // 
            // Purchase_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 351);
            this.Controls.Add(this.lbl_errorqty);
            this.Controls.Add(this.cmb_product);
            this.Controls.Add(this.txt_totalcost);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lbl_totalcost);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_product);
            this.Controls.Add(this.btn_purchase);
            this.Name = "Purchase_product";
            this.Text = "Purchase_product";
            this.Load += new System.EventHandler(this.Purchase_product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbladdproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_ManagementDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_purchase;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_totalcost;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_totalcost;
        private System.Windows.Forms.ComboBox cmb_product;
        private System.Windows.Forms.Label lbl_errorqty;
        private Product_ManagementDataSet1 product_ManagementDataSet1;
        private System.Windows.Forms.BindingSource tbladdproductBindingSource;
        private Product_ManagementDataSet1TableAdapters.tbl_addproductTableAdapter tbl_addproductTableAdapter;
    }
}