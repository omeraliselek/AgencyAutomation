using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastAutomation
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void LinkCreateNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register KayitOl = new Register();
            KayitOl.Show();
            this.Hide();
        }

      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AgencyManagementSystemHome Home = new AgencyManagementSystemHome();
            Home.Show();
            this.Hide();        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //TanerSELEK
        }
    }
}
