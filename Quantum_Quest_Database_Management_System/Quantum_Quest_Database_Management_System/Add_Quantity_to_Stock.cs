using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq.Expressions;



namespace Quantum_Quest_Database_Management_System
{
    public partial class Add_Quantity_to_Stock : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public Add_Quantity_to_Stock()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "SELECT * FROM Stock_Item WHERE Item_Number='" + Convert.ToInt32(txtitemnumbersearch.Text) + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Entered Item Number exists", "Quantum_Quest_Database_Management_System",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtitemname.Text = dr["Item_Name"].ToString();
                    txtcurrentquantity.Text = dr["Quantity"].ToString();
                    txtunitprice.Text = dr["Unit_Price"].ToString();
                    dtptransactiondate.Text = dr["Date"].ToString();


                }
                else
                {
                    MessageBox.Show("Entered Item Number Doesn't Exist. Add the item first", "Quantum_Quest_Database_Management_System",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quantum_Quest_Database_Management_System",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnaddquantitytoitem_Click(object sender, EventArgs e)
        {


            try
            {
                string transactiondate = dtptransactiondate.Value.ToString("yyyy-MM-dd");
                DateTime selectedDate = dtptransactiondate.Value;
                DateTime today = DateTime.Now.Date;

                if (selectedDate >= today && Convert.ToInt32(txtquantityofitem.Text) > 0 )
                {

                    int newQuantity = Convert.ToInt32(txtcurrentquantity.Text) + Convert.ToInt32(txtquantityofitem.Text);

                    string sql = "UPDATE Stock_Item SET Quantity='" + newQuantity + "' WHERE Item_Number='" + Convert.ToInt32(txtitemnumbersearch.Text) + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    string sql2 = "INSERT INTO Transaction_Log (item_number, item_name, Transaction_Date, Quantity_of_the_stock, New_Quantity_Added, Updated_Quantity, Price, Status)VALUES(" + txtitemnumbersearch.Text + ", '" + txtitemname.Text + "', '" + transactiondate + "', '" + txtcurrentquantity.Text + "', '" + txtquantityofitem.Text + "','" + newQuantity + "', '" + txtunitprice.Text + "', '" + "Quantity Added" + "')";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    conn.Open();

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Quantity Added Successfully", "Quantum_Quest_Database_Management_System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd2.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("Invalid Input", "Quantum_Quest_Database_Management_System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (txtitemnumbersearch.Text == "" || txtcurrentquantity.Text == "" || txtquantityofitem.Text == "")
                {
                    MessageBox.Show("Invalid Input, Empty fields are not acceptable", "Quantum_Quest_Database_Management_System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnreturntoadmindashboard_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adb = new Admin_Dashboard();
            adb.Show();
            this.Hide();
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            Add_Item_of_Stock_Form aios = new Add_Item_of_Stock_Form();
            aios.Show();
            this.Hide();
        }

        private void btnreturntoadmindashboard_Click_1(object sender, EventArgs e)
        {
            Admin_Dashboard adb = new Admin_Dashboard();
            adb.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adb = new Admin_Dashboard();
            adb.Show();
            this.Hide();
        }

        private void btnviewtransactionlog_Click(object sender, EventArgs e)
        {
            Transaction_Log_Form tlf = new Transaction_Log_Form();
            tlf.Show();
            this.Hide();
        }
    }
}
