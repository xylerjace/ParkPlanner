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
    public partial class ParkingSpaces : UserControl
    {
        public ParkingSpaces()
        {
            InitializeComponent();
        }

        private void ParkingSpaces_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#272438");
        }
    }
}
