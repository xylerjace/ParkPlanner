using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            // Redraw the form when resized
            ResizeRedraw = true;
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

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
