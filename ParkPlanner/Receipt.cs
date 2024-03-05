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
    public partial class Receipt : Form
    {

        string plateNo;
        string type;
        string brand;
        DateTime parkIn;
        DateTime parkOut;
        int hours;
        int price;
        public Receipt(string plateNo, string type, string brand, DateTime parkIn, DateTime parkOut, int hours, int price)
        {
            InitializeComponent();
            this.plateNo = plateNo;
            this.type = type;
            this.brand = brand;
            this.parkIn = parkIn;
            this.parkOut = parkOut;
            this.hours = hours;
            this.price = price;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#864EFF");

            plateLabel.Text = plateNo;
            typeLabel.Text = type;
            brandLabel.Text = brand;
            timeInLabel.Text = parkIn.ToString();
            parkoutLabel.Text = parkOut.ToString();
            hoursLabel.Text = hours.ToString();
            priceLabel.Text = price.ToString();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
