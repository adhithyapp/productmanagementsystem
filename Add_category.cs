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
    public partial class Add_category : Form
    {
       public static string category;
        public Add_category()
        {
            InitializeComponent();
        }

        private void Add_category_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ll_gotohome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_home ah = new Admin_home();
            this.Hide();
            ah.Show();
        }

        private void btn_addcategory_Click(object sender, EventArgs e)
        {
            category = txt_category.Text;

            //sql connection
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Product_Management;Integrated Security=true");

            //to call stored procedure

            SqlCommand cmd = new SqlCommand("add_category", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //pass value to the storedprocedure
            cmd.Parameters.AddWithValue("@category", category);

            //to execute stored procedure
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Category Added");
            reset();
            
        }
        public void reset()
        {
            txt_category.Text = "";
        }
    }
}
