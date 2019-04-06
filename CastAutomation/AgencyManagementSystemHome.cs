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
    public partial class AgencyManagementSystemHome : Form
    {
        public AgencyManagementSystemHome()
        {
            InitializeComponent();
        }

        private void AgencyManagementSystemHome_Load(object sender, EventArgs e)
        {
            MenuStripHome.ForeColor = Color.Black;
            qRCODEToolStripMenuItem.Enabled = true;
          
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayersList Listele = new PlayersList();
         
          Listele.Show();

            
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register Kayit = new Register();
            Kayit.Show();

        }
    }
}
