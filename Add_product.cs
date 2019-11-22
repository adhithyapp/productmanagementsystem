using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace product_management
{
    public partial class Add_product : Form
    {
        
        string category, productname;
        int price, quantity;
        
        public Add_product()
        {
            InitializeComponent();
        }

        private void Add_product_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ll_gotohome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_home ah = new Admin_home();
            this.Hide();
            ah.Show();
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
           category = cmb_category.Text;
           productname=txt_productname.Text;
           price = Convert.ToInt32(txt_price.Text);
           quantity = Convert.ToInt32(txt_quantity.Text);

            //sql connecton
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Product_Management;Integrated Security=true");

            //to call stored procedure
            SqlCommand cmd = new SqlCommand("add_product", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //pass value to the stored procedure

            cmd.Parameters.AddWithValue("@category",category);
            cmd.Parameters.AddWithValue("@productname",productname);
            cmd.Parameters.AddWithValue("@price",price);
            cmd.Parameters.AddWithValue("@quantity",quantity);

            //to execute stored procedure
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product added");
            reset();
        }
        public void reset()
        {
            cmb_category.Text = "";
            txt_productname.Text = "";
            txt_price.Text = "";
            txt_quantity.Text = "";
        }

        private void Add_product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'product_ManagementDataSet.tbl_addcategory' table. You can move, or remove it, as needed.
            this.tbl_addcategoryTableAdapter.Fill(this.product_ManagementDataSet.tbl_addcategory);

        }
    }
}
