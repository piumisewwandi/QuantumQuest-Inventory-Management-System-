using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quantum_Quest_Database_Management_System
{
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void btnloginwithmb_Click(object sender, EventArgs e)
        {
            if (txtuserwithmb.Text.Equals("admin") && txtmobilenumber.Text.Equals("0760366365"))
            {
                Admin_Dashboard adf = new Admin_Dashboard();
                adf.Show();
                this.Hide();
            }
            else
            {
                lblerrorcode.Text = "Invalid Username or Mobile Number, Please Try Again Later";
            }
        }

        private void btnreturnlogin_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }
    }
}
