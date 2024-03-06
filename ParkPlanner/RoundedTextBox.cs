using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ParkPlanner
{
    public class RoundedTextBox : TextBox
    {
        public int CornerRadius { get; set; } = 10; // Adjust the corner radius as needed

        public RoundedTextBox()
        {
            this.BorderStyle = BorderStyle.None;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            int radius = CornerRadius;
            int width = Width;
            int height = Height;

            path.AddArc(0, 0, radius, radius, 180, 90); // Top left corner
            path.AddArc(width - radius, 0, radius, radius, 270, 90); // Top right corner
            path.AddArc(width - radius, height - radius, radius, radius, 0, 90); // Bottom right corner
            path.AddArc(0, height - radius, radius, radius, 90, 90); // Bottom left corner
            path.CloseAllFigures();

            this.Region = new Region(path);
        }
    }
}
