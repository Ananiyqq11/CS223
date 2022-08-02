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
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Form1 a = new Form1("Admin");
            a.MdiParent = this;
            a.Show(); 
        }

        private void loginToProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Login a = new Login();
            a.MdiParent = this;
            a.Show();

           

        }

        private void secondpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();  
            }   
            second_page s = new second_page();
            s.MdiParent=this;
            s.Show();
        }
    }
}
