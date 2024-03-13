namespace ParkPlanner
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginPanel = new RoundedPanel();
            signinButton = new RoundedButton();
            label7 = new Label();
            validate = new Label();
            password = new RoundedTextBox();
            userName = new RoundedTextBox();
            label6 = new Label();
            leftPanel = new RoundedPanel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            LoginPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(signinButton);
            LoginPanel.Controls.Add(label7);
            LoginPanel.Controls.Add(validate);
            LoginPanel.Controls.Add(password);
            LoginPanel.Controls.Add(userName);
            LoginPanel.Controls.Add(label6);
            LoginPanel.Controls.Add(leftPanel);
            LoginPanel.CornerRadius = 30;
            LoginPanel.Location = new Point(107, 39);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(572, 404);
            LoginPanel.TabIndex = 1;
            LoginPanel.Paint += LoginPanel_Paint;
            // 
            // signinButton
            // 
            signinButton.BackColor = Color.FromArgb(166, 62, 21);
            signinButton.CornerRadius = 30;
            signinButton.FlatAppearance.BorderSize = 0;
            signinButton.FlatStyle = FlatStyle.Flat;
            signinButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signinButton.ForeColor = Color.White;
            signinButton.Location = new Point(348, 286);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(196, 44);
            signinButton.TabIndex = 6;
            signinButton.Text = "Sign In";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += signinButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(379, 216);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 5;
            label7.Text = "Username not found";
            label7.Visible = false;
            // 
            // validate
            // 
            validate.AutoSize = true;
            validate.BackColor = Color.Transparent;
            validate.ForeColor = Color.Red;
            validate.Location = new Point(388, 216);
            validate.Name = "validate";
            validate.Size = new Size(107, 15);
            validate.TabIndex = 4;
            validate.Text = "Incorrect Password";
            validate.Visible = false;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            password.CornerRadius = 30;
            password.Cursor = Cursors.IBeam;
            password.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(348, 164);
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(196, 26);
            password.TabIndex = 3;
            password.UseSystemPasswordChar = true;
            // 
            // userName
            // 
            userName.BorderStyle = BorderStyle.FixedSingle;
            userName.CornerRadius = 30;
            userName.Cursor = Cursors.IBeam;
            userName.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userName.Location = new Point(348, 106);
            userName.Name = "userName";
            userName.PlaceholderText = "Username";
            userName.Size = new Size(196, 25);
            userName.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(413, 16);
            label6.Name = "label6";
            label6.Size = new Size(53, 19);
            label6.TabIndex = 1;
            label6.Text = "Login";
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(label9);
            leftPanel.Controls.Add(label8);
            leftPanel.Controls.Add(label5);
            leftPanel.Controls.Add(label4);
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(label2);
            leftPanel.Controls.Add(label1);
            leftPanel.CornerRadius = 40;
            leftPanel.Location = new Point(3, 3);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(304, 398);
            leftPanel.TabIndex = 0;
            leftPanel.Paint += leftPanel_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(133, 363);
            label5.Name = "label5";
            label5.Size = new Size(100, 30);
            label5.TabIndex = 5;
            label5.Text = "Planner";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(80, 365);
            label4.Name = "label4";
            label4.Size = new Size(61, 27);
            label4.TabIndex = 4;
            label4.Text = "Park";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(124, 345);
            label3.Name = "label3";
            label3.Size = new Size(39, 18);
            label3.TabIndex = 3;
            label3.Text = "With";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 283);
            label2.Name = "label2";
            label2.Size = new Size(281, 24);
            label2.TabIndex = 2;
            label2.Text = "Management Made Powerful.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 244);
            label1.Name = "label1";
            label1.Size = new Size(255, 27);
            label1.TabIndex = 1;
            label1.Text = "Parking Made Simple, ";
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(80, 39);
            label8.Name = "label8";
            label8.Size = new Size(155, 56);
            label8.TabIndex = 6;
            label8.Text = "PARK";
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(30, 116);
            label9.Name = "label9";
            label9.Size = new Size(255, 56);
            label9.TabIndex = 7;
            label9.Text = "PLANNER";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(787, 528);
            Controls.Add(LoginPanel);
            MaximizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel LoginPanel;
        private RoundedPanel leftPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private RoundedTextBox userName;
        private RoundedTextBox password;
        private Label validate;
        private Label label7;
        private RoundedButton signinButton;
        private Label label9;
        private Label label8;
    }
}
