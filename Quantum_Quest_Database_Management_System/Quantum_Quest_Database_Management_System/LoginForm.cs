namespace Quantum_Quest_Database_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
           if (txtusername.Text.Equals("admin") && txtpassword.Text.Equals("1234"))
            {
                Admin_Dashboard adf = new Admin_Dashboard();
                adf.Show();
                this.Hide();
            }
            else
            {
                lblerror.Text = "Invalid Username or password";
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void linklblforgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password fgd = new Forgot_Password();
            fgd.Show();
            this.Hide();
        }
    }
}