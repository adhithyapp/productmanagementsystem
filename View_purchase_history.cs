using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_management
{
    public partial class View_purchase_history : Form
    {
        public View_purchase_history()
        {
            InitializeComponent();
        }

        private void ll_gotohome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_home ah = new Admin_home();
            this.Hide();
            ah.Show();
        }

        private void View_purchase_history_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
