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
    public partial class Edit_profile : Form
    {
        string email, phone;
        string user;
        //sql connection
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Product_Management;Integrated Security=true");
        SqlCommand cmd;
        public Edit_profile()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Close();
            email = txt_email.Text;
            phone = txt_phone.Text;
            cmd = new SqlCommand("update_data", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //to pass values to the stored procedure
            cmd.Parameters.AddWithValue("@username",user );
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            //execute stored procedure
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updated");
            User_home uh = new User_home();
            //this.Hide();
            uh.ShowDialog();
            
     
        }

        private void Edit_profile_Load(object sender, EventArgs e)
        {
            user = User_home.uname;
           
            cmd = new SqlCommand("edit_data", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", user);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
                {
                txt_email.Text = sdr["email"].ToString();
                txt_phone.Text = sdr["phone"].ToString();

            }
         
        }
      
    }
}
