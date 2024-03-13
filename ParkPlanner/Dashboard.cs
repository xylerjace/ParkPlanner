using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkPlanner
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Overview overview = new Overview(this);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(14, 13, 14);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(14, 13, 14);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }
        public void HideDashboard()
        {
            this.Hide();
        }

        public void ShowDashboard()
        {
            this.Show();
        }
        public void disableLogout() { 
            roundedButton1.Enabled = false;
        }
        public void enableLogout() { 
            roundedButton1.Enabled=true;
        }
    }
}
