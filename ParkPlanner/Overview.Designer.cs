namespace ParkPlanner
{
    partial class Overview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            ParkinPanel = new RoundedPanel();
            parkInButton = new RoundedButton();
            brandComboBox = new ComboBox();
            label7 = new Label();
            sedanButton = new RoundedButton();
            suvButton = new RoundedButton();
            motorButton = new RoundedButton();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label2 = new Label();
            availPanel = new RoundedPanel();
            label3 = new Label();
            availText = new Label();
            occupiedPanel = new RoundedPanel();
            label4 = new Label();
            occupiedText = new Label();
            parkoutPanel = new RoundedPanel();
            titlePanel = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            parkoutButton = new RoundedButton();
            parkoutList = new ListBox();
            label8 = new Label();
            ParkinPanel.SuspendLayout();
            availPanel.SuspendLayout();
            occupiedPanel.SuspendLayout();
            parkoutPanel.SuspendLayout();
            titlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(121, 30);
            label1.TabIndex = 0;
            label1.Text = "Overview";
            // 
            // ParkinPanel
            // 
            ParkinPanel.BackColor = Color.FromArgb(78, 179, 255);
            ParkinPanel.Controls.Add(parkInButton);
            ParkinPanel.Controls.Add(brandComboBox);
            ParkinPanel.Controls.Add(label7);
            ParkinPanel.Controls.Add(sedanButton);
            ParkinPanel.Controls.Add(suvButton);
            ParkinPanel.Controls.Add(motorButton);
            ParkinPanel.Controls.Add(label6);
            ParkinPanel.Controls.Add(textBox1);
            ParkinPanel.Controls.Add(label5);
            ParkinPanel.Controls.Add(label2);
            ParkinPanel.CornerRadius = 60;
            ParkinPanel.Location = new Point(20, 60);
            ParkinPanel.Name = "ParkinPanel";
            ParkinPanel.Size = new Size(437, 270);
            ParkinPanel.TabIndex = 1;
            // 
            // parkInButton
            // 
            parkInButton.BackColor = Color.FromArgb(53, 96, 208);
            parkInButton.CornerRadius = 10;
            parkInButton.FlatAppearance.BorderSize = 0;
            parkInButton.FlatStyle = FlatStyle.Flat;
            parkInButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkInButton.ForeColor = Color.White;
            parkInButton.Location = new Point(151, 236);
            parkInButton.Name = "parkInButton";
            parkInButton.Size = new Size(140, 31);
            parkInButton.TabIndex = 9;
            parkInButton.Text = "Park In";
            parkInButton.UseVisualStyleBackColor = false;
            parkInButton.Click += parkInButton_Click;
            // 
            // brandComboBox
            // 
            brandComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brandComboBox.Location = new Point(151, 203);
            brandComboBox.Name = "brandComboBox";
            brandComboBox.Size = new Size(146, 24);
            brandComboBox.Sorted = true;
            brandComboBox.TabIndex = 8;
            brandComboBox.Text = "Select Brand";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(151, 180);
            label7.Name = "label7";
            label7.Size = new Size(140, 16);
            label7.TabIndex = 7;
            label7.Text = "Select Vehicle Brand";
            // 
            // sedanButton
            // 
            sedanButton.BackColor = Color.FromArgb(53, 96, 208);
            sedanButton.CornerRadius = 10;
            sedanButton.FlatAppearance.BorderSize = 0;
            sedanButton.FlatStyle = FlatStyle.Flat;
            sedanButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sedanButton.ForeColor = Color.White;
            sedanButton.Location = new Point(286, 137);
            sedanButton.Name = "sedanButton";
            sedanButton.Size = new Size(104, 29);
            sedanButton.TabIndex = 6;
            sedanButton.Text = "Sedan";
            sedanButton.UseVisualStyleBackColor = false;
            sedanButton.Click += sedanButton_Click;
            // 
            // suvButton
            // 
            suvButton.BackColor = Color.FromArgb(53, 96, 208);
            suvButton.CornerRadius = 10;
            suvButton.FlatAppearance.BorderSize = 0;
            suvButton.FlatStyle = FlatStyle.Flat;
            suvButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suvButton.ForeColor = Color.White;
            suvButton.Location = new Point(168, 137);
            suvButton.Name = "suvButton";
            suvButton.Size = new Size(101, 29);
            suvButton.TabIndex = 5;
            suvButton.Text = "SUV / Van";
            suvButton.UseVisualStyleBackColor = false;
            suvButton.Click += suvButton_Click;
            // 
            // motorButton
            // 
            motorButton.BackColor = Color.FromArgb(53, 96, 208);
            motorButton.CornerRadius = 10;
            motorButton.FlatAppearance.BorderSize = 0;
            motorButton.FlatStyle = FlatStyle.Flat;
            motorButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            motorButton.ForeColor = Color.White;
            motorButton.Location = new Point(38, 137);
            motorButton.Name = "motorButton";
            motorButton.Size = new Size(111, 29);
            motorButton.TabIndex = 4;
            motorButton.Text = "Motorcycle";
            motorButton.UseVisualStyleBackColor = false;
            motorButton.Click += motorButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(151, 98);
            label6.Name = "label6";
            label6.Size = new Size(132, 16);
            label6.TabIndex = 3;
            label6.Text = "Select Vehicle Type";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(175, 40);
            label5.Name = "label5";
            label5.Size = new Size(94, 16);
            label5.TabIndex = 1;
            label5.Text = "Plate Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 11);
            label2.Name = "label2";
            label2.Size = new Size(93, 29);
            label2.TabIndex = 0;
            label2.Text = "Park In";
            // 
            // availPanel
            // 
            availPanel.BackColor = Color.FromArgb(134, 78, 255);
            availPanel.Controls.Add(label3);
            availPanel.Controls.Add(availText);
            availPanel.CornerRadius = 60;
            availPanel.Location = new Point(494, 60);
            availPanel.Name = "availPanel";
            availPanel.Size = new Size(182, 125);
            availPanel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 98);
            label3.Name = "label3";
            label3.Size = new Size(127, 18);
            label3.TabIndex = 1;
            label3.Text = "Available Spaces";
            // 
            // availText
            // 
            availText.AutoSize = true;
            availText.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            availText.ForeColor = Color.White;
            availText.Location = new Point(51, 26);
            availText.Name = "availText";
            availText.Size = new Size(78, 56);
            availText.TabIndex = 0;
            availText.Text = "12";
            // 
            // occupiedPanel
            // 
            occupiedPanel.BackColor = Color.FromArgb(80, 255, 145);
            occupiedPanel.Controls.Add(label4);
            occupiedPanel.Controls.Add(occupiedText);
            occupiedPanel.CornerRadius = 60;
            occupiedPanel.Location = new Point(494, 211);
            occupiedPanel.Name = "occupiedPanel";
            occupiedPanel.Size = new Size(182, 119);
            occupiedPanel.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 86);
            label4.Name = "label4";
            label4.Size = new Size(143, 19);
            label4.TabIndex = 1;
            label4.Text = "Occupied Spaces";
            // 
            // occupiedText
            // 
            occupiedText.AutoSize = true;
            occupiedText.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            occupiedText.ForeColor = Color.White;
            occupiedText.Location = new Point(51, 19);
            occupiedText.Name = "occupiedText";
            occupiedText.Size = new Size(78, 56);
            occupiedText.TabIndex = 0;
            occupiedText.Text = "13";
            // 
            // parkoutPanel
            // 
            parkoutPanel.BackColor = Color.FromArgb(255, 192, 75);
            parkoutPanel.Controls.Add(titlePanel);
            parkoutPanel.Controls.Add(parkoutButton);
            parkoutPanel.Controls.Add(parkoutList);
            parkoutPanel.Controls.Add(label8);
            parkoutPanel.CornerRadius = 60;
            parkoutPanel.Location = new Point(20, 364);
            parkoutPanel.Name = "parkoutPanel";
            parkoutPanel.Size = new Size(656, 236);
            parkoutPanel.TabIndex = 4;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.FromArgb(69, 68, 57);
            titlePanel.Controls.Add(label12);
            titlePanel.Controls.Add(label11);
            titlePanel.Controls.Add(label10);
            titlePanel.Controls.Add(label9);
            titlePanel.Location = new Point(70, 25);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(490, 30);
            titlePanel.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(372, 7);
            label12.Name = "label12";
            label12.Size = new Size(60, 18);
            label12.TabIndex = 3;
            label12.Text = "Time In";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(216, 7);
            label11.Name = "label11";
            label11.Size = new Size(51, 18);
            label11.TabIndex = 2;
            label11.Text = "Brand";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(105, 7);
            label10.Name = "label10";
            label10.Size = new Size(42, 18);
            label10.TabIndex = 1;
            label10.Text = "Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 7);
            label9.Name = "label9";
            label9.Size = new Size(72, 18);
            label9.TabIndex = 0;
            label9.Text = "Plate No.";
            // 
            // parkoutButton
            // 
            parkoutButton.BackColor = Color.FromArgb(153, 116, 47);
            parkoutButton.CornerRadius = 10;
            parkoutButton.FlatAppearance.BorderSize = 0;
            parkoutButton.FlatStyle = FlatStyle.Flat;
            parkoutButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkoutButton.ForeColor = Color.White;
            parkoutButton.Location = new Point(558, 82);
            parkoutButton.Name = "parkoutButton";
            parkoutButton.Size = new Size(95, 68);
            parkoutButton.TabIndex = 2;
            parkoutButton.Text = "Park Out";
            parkoutButton.UseVisualStyleBackColor = false;
            parkoutButton.Click += parkoutButton_Click;
            // 
            // parkoutList
            // 
            parkoutList.BackColor = Color.FromArgb(255, 192, 75);
            parkoutList.BorderStyle = BorderStyle.None;
            parkoutList.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkoutList.ForeColor = Color.Black;
            parkoutList.FormattingEnabled = true;
            parkoutList.ItemHeight = 18;
            parkoutList.Location = new Point(70, 53);
            parkoutList.Name = "parkoutList";
            parkoutList.Size = new Size(473, 180);
            parkoutList.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(274, 0);
            label8.Name = "label8";
            label8.Size = new Size(96, 22);
            label8.TabIndex = 0;
            label8.Text = "Park Out ";
            // 
            // Overview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(parkoutPanel);
            Controls.Add(occupiedPanel);
            Controls.Add(availPanel);
            Controls.Add(ParkinPanel);
            Controls.Add(label1);
            Name = "Overview";
            Size = new Size(700, 592);
            Load += Overview_Load;
            ParkinPanel.ResumeLayout(false);
            ParkinPanel.PerformLayout();
            availPanel.ResumeLayout(false);
            availPanel.PerformLayout();
            occupiedPanel.ResumeLayout(false);
            occupiedPanel.PerformLayout();
            parkoutPanel.ResumeLayout(false);
            parkoutPanel.PerformLayout();
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RoundedPanel ParkinPanel;
        private RoundedPanel availPanel;
        private RoundedPanel occupiedPanel;
        private RoundedPanel parkoutPanel;
        private Label label3;
        private Label availText;
        private Label label4;
        private Label occupiedText;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private Label label2;
        private RoundedButton sedanButton;
        private RoundedButton suvButton;
        private RoundedButton motorButton;
        private Label label7;
        private RoundedButton parkInButton;
        private ComboBox brandComboBox;
        private ListBox parkoutList;
        private Label label8;
        private RoundedButton parkoutButton;
        private Panel titlePanel;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label11;
    }
}
