using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;


namespace Quantum_Quest_Database_Management_System
{
    public partial class Transaction_Log_Form : Form
    {
        private SqlConnection conn;

        public Transaction_Log_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnreturndashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adb = new Admin_Dashboard();
            adb.Show();
            this.Hide();
        }

        private void Transaction_Log_Form_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-FIO7IV4\\SQLEXPRESS;Initial Catalog=Quantum_Quest_Database_Management;Integrated Security=True;Pooling=False");

            try
            {
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string Tablegrid = "SELECT * FROM Transaction_Log";
                    SqlDataAdapter Adp = new SqlDataAdapter(Tablegrid, conn);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Connection is not initialized.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Quantity_to_Stock aqts = new Add_Quantity_to_Stock();
            aqts.Show();
            this.Hide();
        }

        private void btnaddtostock_Click(object sender, EventArgs e)
        {
            Add_Item_of_Stock_Form aios = new Add_Item_of_Stock_Form();
            aios.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adb = new Admin_Dashboard();
            adb.Show();
            this.Hide();
        }

        private void lblcurrentdate_Click(object sender, EventArgs e)
        {

        }
    }

}

