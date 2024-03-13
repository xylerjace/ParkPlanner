using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ParkPlanner
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 60; // Adjust the corner radius as needed

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

            Color startColor = Color.FromArgb(132, 41, 3);
            Color endColor = Color.Black;

            // Create a linear gradient brush
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Vertical);

            // Set the blending factors
            brush.Blend = new Blend
            {
                Factors = new float[] { 0.6f, 1f }, // 80% startColor, 100% endColor
                Positions = new float[] { 0f, 1f } // Blend at the start and end
            };

            // Fill the panel with the gradient brush
            e.Graphics.FillPath(brush, path);
        }
    }
}
