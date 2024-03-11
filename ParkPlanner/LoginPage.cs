namespace ParkPlanner
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#272438");
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {
            LoginPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
        }


        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {
            leftPanel.BackColor = System.Drawing.ColorTranslator.FromHtml("#4EB3FF");
        }

        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
