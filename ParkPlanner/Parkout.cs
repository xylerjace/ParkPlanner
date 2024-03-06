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
    public partial class Parkout : Form
    {
        string plateNo;
        string brand;
        string type;
        DateTime parkin;
        int flagDown;
        int additional;
        Overview overview;
        int occupied;
        int available;
        public Parkout(string plateNo, string brand, string type, DateTime parkin, int flagDown, int additional, Overview overview, int occupied, int available)
        {
            InitializeComponent();
            this.plateNo = plateNo;
            this.type = type;
            this.brand = brand;
            this.parkin = parkin;
            this.flagDown = flagDown;
            this.additional = additional;
            this.overview = overview;
            this.occupied = occupied;
            this.available = available;
        }

        private void Parkout_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#E54F4F");
            plate.Text = plateNo;
            brandLabel.Text = brand;
            typeLabel.Text = type;
            timeIn.Text = parkin.ToString();

        }

        private void timeOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Click(object sender, EventArgs e)
        {
            DateTime parkOut = DateTime.Parse(timeOut.Text);

            TimeSpan duration = parkOut - parkin;
            int hours = (int)Math.Ceiling(duration.TotalHours);

            int payment = (hours * additional) + flagDown;

            
            if (hours > 0)
            {

                Receipt receipt = new Receipt(plateNo, type, brand, parkin, parkOut, hours, payment);
                receipt.Show();
                this.Hide();
               
                overview.UpdateOccupied();
                overview.UpdateAvailable();

            }
            else
            {
                MessageBox.Show("Invalid parkOut time. Please enter a valid date and time.");
            }
        }
    }
}