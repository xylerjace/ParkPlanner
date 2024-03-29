﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
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
        Vehicle selectedVehicle;
        Dashboard dash;
        public Parkout(string plateNo, string brand, string type, DateTime parkin, int flagDown, int additional, Overview overview, int occupied, int available, Vehicle selectedVehicle,Dashboard dash)
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
            this.selectedVehicle = selectedVehicle;
            this.dash = dash;

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            // Redraw the form when resized
            ResizeRedraw = true;
            this.selectedVehicle = selectedVehicle;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawGradientBackground(e.Graphics);
        }

        private void DrawGradientBackground(Graphics g)
        {
            Rectangle rect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.FromArgb(162, 61, 23), Color.Black, LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, rect);
            }
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
            DateTime parkOut;
            if (DateTime.TryParseExact(timeOut.Text, "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out parkOut))
            {
                TimeSpan duration = parkOut - parkin;
                int hours = (int)Math.Floor(duration.TotalHours);

                int payment = (hours * additional) + flagDown;

                if (hours >= 0)
                {
                    
                    
                    overview.removeItem(selectedVehicle);
                    Receipt receipt = new Receipt(plateNo, type, brand, parkin, parkOut, hours, payment, overview,dash);
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
            else
            {
                MessageBox.Show("Invalid parkOut time format. Please enter the date and time in the format mm/dd/yyyy hh:mm:ss tt.");
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.enableLogout();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        
    }
}