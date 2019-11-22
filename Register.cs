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
using System.Net.Mail;

namespace product_management
{
    public partial class Register : Form
    {
        string name, address, phone, email, username, password;
        public Register()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ll_gotologin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            name = txt_name.Text;
            address = txt_address.Text;
            phone = txt_phone.Text;
            email = txt_email.Text;
            username = txt_username.Text;
            password = txt_password.Text;

            //sql connection
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Product_Management;Integrated Security=true");
           
            //call stored procedure
            SqlCommand cmd = new SqlCommand("add_data", con);
            cmd.CommandType = CommandType.StoredProcedure;
           
            //pass value to stored procedure
            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@address",address);
            cmd.Parameters.AddWithValue("@phone",phone);
            cmd.Parameters.AddWithValue("@email",email);
            cmd.Parameters.AddWithValue("@username",username);
            cmd.Parameters.AddWithValue("@password",password);

            //to execute stored procedure
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registered");
            sendMail();
            reset();
        }

        public void reset()
        {
            txt_name.Text = "";
            txt_address.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_username.Text = "";
            txt_password.Text = "";
        }

        void sendMail()
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("adhithyapp1997@gmail.com");
            mail.To.Add(txt_email.Text);
            mail.Subject = "Confirmation mail";
            mail.Body = "username : " + username + "\n" + "password : " + password;
            SmtpClient smt = new SmtpClient();
            smt.Host = "smtp.gmail.com";
            System.Net.NetworkCredential ntwd = new System.Net.NetworkCredential();
            ntwd.UserName = "adhithyapp1997@gmail.com"; //Your Email ID  
            ntwd.Password = "adhithya1435"; // Your Password  
            smt.UseDefaultCredentials = true;
            smt.Credentials = ntwd;
            smt.Port = 587;
            smt.EnableSsl = true;
            smt.Send(mail);
        }
    }
}
