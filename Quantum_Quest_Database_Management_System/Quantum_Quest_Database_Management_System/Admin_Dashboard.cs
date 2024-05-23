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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Quantity_to_Stock aqts = new Add_Quantity_to_Stock();
            aqts.Show();
            this.Hide();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            Add_Item_of_Stock_Form aios = new Add_Item_of_Stock_Form();
            aios.Show();
            this.Hide();
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void btnviewtransactionlog_Click(object sender, EventArgs e)
        {
            Transaction_Log_Form tlf = new Transaction_Log_Form();
            tlf.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adb = new Admin_Dashboard();
            adb.Show();
            this.Hide();
        }
    }
}

