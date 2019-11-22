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
    public partial class Purchase_product : Form
    {
        string productname;
        int current_quantity, txtquantity, price,totalcost;
        //sql connection
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Product_Management;Integrated Security=true");
        SqlCommand cmd;
        public Purchase_product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string s = dateTime.ToString("dd/MM/yyyy");
            MessageBox.Show(s);
        }

        private void Purchase_product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'product_ManagementDataSet1.tbl_addproduct' table. You can move, or remove it, as needed.
            this.tbl_addproductTableAdapter.Fill(this.product_ManagementDataSet1.tbl_addproduct);

        }

        private void cmb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            productname = cmb_product.Text;
            cmd = new SqlCommand("fetch_data",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productname", productname);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txt_price.Text = sdr["price"].ToString();
                current_quantity = (int)sdr["quantity"];
               
            }
            
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            con.Close();
            txtquantity = Convert.ToInt32(txt_quantity.Text);
           if(txtquantity<=current_quantity)
            {
                lbl_errorqty.Text = "";
                price = Convert.ToInt32(txt_price.Text);
                totalcost = price * txtquantity;
                txt_totalcost.Text = totalcost.ToString();

            }
            else
            {
                lbl_errorqty.Text = "Out Of Stock";
               
            }
            }

        }
    }

