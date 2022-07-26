using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExcer01
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Equals("admin") && txt_password.Text.Equals("pass123"))
            {
                Visible = false;
                Form1 form1 = new Form1("admin");
                form1.Show();
            }
            else
                MessageBox.Show("INVALID USER INFO!!!");

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
