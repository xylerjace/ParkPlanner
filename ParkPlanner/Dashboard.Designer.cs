namespace ParkPlanner
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            roundedButton1 = new RoundedButton();
            overviewButton = new RoundedButton();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            overview1 = new Overview();
            parkingSpaces1 = new ParkingSpaces();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(overviewButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 592);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(166, 62, 21);
            roundedButton1.CornerRadius = 10;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(34, 522);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(115, 41);
            roundedButton1.TabIndex = 2;
            roundedButton1.Text = "Logout";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // overviewButton
            // 
            overviewButton.BackColor = Color.FromArgb(166, 62, 21);
            overviewButton.CornerRadius = 10;
            overviewButton.FlatAppearance.BorderSize = 0;
            overviewButton.FlatStyle = FlatStyle.Flat;
            overviewButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            overviewButton.ForeColor = Color.White;
            overviewButton.Location = new Point(3, 127);
            overviewButton.Name = "overviewButton";
            overviewButton.Size = new Size(194, 47);
            overviewButton.TabIndex = 1;
            overviewButton.Text = "Overview";
            overviewButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(42, 40);
            label2.Name = "label2";
            label2.Size = new Size(125, 30);
            label2.TabIndex = 1;
            label2.Text = "PLANNER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 10);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 1;
            label1.Text = "PARK";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(39, 36, 56);
            panel2.Controls.Add(overview1);
            panel2.Controls.Add(parkingSpaces1);
            panel2.Location = new Point(204, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 592);
            panel2.TabIndex = 1;
            // 
            // overview1
            // 
            overview1.BackColor = Color.FromArgb(39, 36, 56);
            overview1.Dock = DockStyle.Fill;
            overview1.Location = new Point(0, 0);
            overview1.Name = "overview1";
            overview1.Size = new Size(700, 592);
            overview1.TabIndex = 0;
            // 
            // parkingSpaces1
            // 
            parkingSpaces1.BackColor = Color.FromArgb(39, 36, 56);
            parkingSpaces1.Dock = DockStyle.Fill;
            parkingSpaces1.Location = new Point(0, 0);
            parkingSpaces1.Name = "parkingSpaces1";
            parkingSpaces1.Size = new Size(700, 592);
            parkingSpaces1.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 591);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private RoundedButton overviewButton;
        private Panel panel2;
        private Overview overview1;
        private ParkingSpaces parkingSpaces1;
        private RoundedButton roundedButton1;
    }
}