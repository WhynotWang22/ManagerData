using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManagerData

{


    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Center;

            this.ResumeLayout(false);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Please enter both username and password.");
            }
            else if (txt_username.Text == "admin" && txt_password.Text == "1")
            {
                MessageBox.Show("Login successful!");
                txt_username.Clear();
                txt_password.Clear();
                DataScreen dataScreen = new DataScreen();
                dataScreen.Show();
                this.Hide();
            }
            else
            {
                txt_username.Clear();
                txt_password.Clear();
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void txt_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
