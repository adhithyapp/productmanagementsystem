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
    public partial class Login : Form
    {
        public static string u = "";
        string username, password;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ll_newuser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            username = txt_username.Text;
            u = username;
            password = txt_password.Text;


            if (username=="admin" && password=="admin")
            {
                Admin_home ah = new Admin_home();
                this.Hide();
                ah.Show();
            }
            else
            {
               
                //sql connection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Product_Management;Integrated Security=true");

                //to call stored procedure

                SqlCommand cmd = new SqlCommand("login_data", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //pass the value to the stored procedure
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                //execute stored procedure
                con.Open();
                int i = (int)cmd.ExecuteScalar();
                if(i>0)
                {
                    User_home uh = new User_home();
                    this.Hide();
                    uh.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username & password");
                }
            }

        }
    }
}
