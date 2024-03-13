namespace ParkPlanner
{
    partial class Parkout
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
            label1 = new Label();
            plate = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            timeIn = new Label();
            label9 = new Label();
            timeOut = new TextBox();
            button = new RoundedButton();
            label10 = new Label();
            typeLabel = new Label();
            brandLabel = new Label();
            roundedButton1 = new RoundedButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 69);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 0;
            label1.Text = "Plate Number";
            // 
            // plate
            // 
            plate.AutoSize = true;
            plate.BackColor = Color.Transparent;
            plate.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plate.ForeColor = Color.White;
            plate.Location = new Point(249, 69);
            plate.Name = "plate";
            plate.Size = new Size(50, 18);
            plate.TabIndex = 1;
            plate.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(62, 129);
            label3.Name = "label3";
            label3.Size = new Size(105, 19);
            label3.TabIndex = 2;
            label3.Text = "Vehicle Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(62, 185);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 4;
            label5.Text = "Brand";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(62, 236);
            label7.Name = "label7";
            label7.Size = new Size(103, 19);
            label7.TabIndex = 6;
            label7.Text = "Date Time In";
            // 
            // timeIn
            // 
            timeIn.AutoSize = true;
            timeIn.BackColor = Color.Transparent;
            timeIn.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeIn.ForeColor = Color.White;
            timeIn.Location = new Point(249, 236);
            timeIn.Name = "timeIn";
            timeIn.Size = new Size(50, 18);
            timeIn.TabIndex = 7;
            timeIn.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(62, 296);
            label9.Name = "label9";
            label9.Size = new Size(116, 19);
            label9.TabIndex = 8;
            label9.Text = "Date Time Out";
            // 
            // timeOut
            // 
            timeOut.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeOut.Location = new Point(198, 292);
            timeOut.Name = "timeOut";
            timeOut.Size = new Size(221, 25);
            timeOut.TabIndex = 9;
            timeOut.TextChanged += timeOut_TextChanged;
            // 
            // button
            // 
            button.BackColor = Color.FromArgb(166, 62, 21);
            button.CornerRadius = 10;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button.ForeColor = Color.White;
            button.Location = new Point(261, 384);
            button.Name = "button";
            button.Size = new Size(131, 46);
            button.TabIndex = 10;
            button.Text = "Park Out";
            button.UseVisualStyleBackColor = false;
            button.Click += button_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(166, 9);
            label10.Name = "label10";
            label10.Size = new Size(122, 27);
            label10.TabIndex = 11;
            label10.Text = "PARK OUT";
            label10.Click += label10_Click;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.BackColor = Color.Transparent;
            typeLabel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            typeLabel.ForeColor = Color.White;
            typeLabel.Location = new Point(249, 129);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(50, 18);
            typeLabel.TabIndex = 12;
            typeLabel.Text = "label2";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.BackColor = Color.Transparent;
            brandLabel.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brandLabel.ForeColor = Color.White;
            brandLabel.Location = new Point(249, 185);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(50, 18);
            brandLabel.TabIndex = 13;
            brandLabel.Text = "label4";
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(166, 62, 21);
            roundedButton1.CornerRadius = 10;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(19, 384);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(112, 45);
            roundedButton1.TabIndex = 14;
            roundedButton1.Text = "Cancel";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // Parkout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 442);
            Controls.Add(roundedButton1);
            Controls.Add(brandLabel);
            Controls.Add(typeLabel);
            Controls.Add(label10);
            Controls.Add(button);
            Controls.Add(timeOut);
            Controls.Add(label9);
            Controls.Add(timeIn);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(plate);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Parkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parkout";
            Load += Parkout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label plate;
        private Label label3;
       
        private Label label5;
       
        private Label label7;
        private Label timeIn;
        private Label label9;
        private TextBox timeOut;
        private RoundedButton button;
        private Label label10;
        private Label typeLabel;
        private Label brandLabel;
        private RoundedButton roundedButton1;
    }
}