using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Quantum_Quest_Database_Management_System
{
    public partial class Add_Item_of_Stock_Form : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public Add_Item_of_Stock_Form()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblitemname_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnaddtostock_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtitemnumber.Text) || string.IsNullOrEmpty(txtitemname.Text) || string.IsNullOrEmpty(txtitemdescription.Text) || string.IsNullOrEmpty(updownquantity.Text) || string.IsNullOrEmpty(txtunitprice.Text) || !(Convert.ToInt32(updownquantity.Text) > 0))
                {
                    MessageBox.Show("Invalid Input, Empty fields are not acceptable.", "Quantum_Quest_Database_Management_System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DateTime selectedDate = dtpdate.Value;

                    DateTime today = DateTime.Now.Date;

                   
                    if (selectedDate >= today)
                    {
                        
                        string transdate = selectedDate.ToString("yyyy-MM-dd");
                        int quantityvalue = (int)updownquantity.Value;

                        string sql = "INSERT INTO Stock_Item(Item_Number ,Item_Name, Description, Date, Quantity, Unit_Price)VALUES('" + txtitemnumber.Text + "', '" + txtitemname.Text + "', '" + txtitemdescription.Text + "', '" + transdate + "', '" + quantityvalue + "', '" + txtunitprice.Text + "')";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        string sql1 = "INSERT INTO Transaction_Log(item_number ,item_name ,Transaction_Date, Quantity_of_the_Stock, Price)VALUES('" + txtitemnumber.Text + "', '" + txtitemname.Text + "', '" + transdate + "', '" + quantityvalue + "', '" + txtunitprice.Text + "')";
                        SqlCommand cmd1 = new SqlCommand(sql1, conn);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Item Added Successfully ", "Quantum Quest Database Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        
                        MessageBox.Show("Past date is not allowed for this operation", "Quantum_Quest_Database_Management_System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quantum_Quest_Database_Management_System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }


        }

        private void btnreturndashboard_Click(object sender, EventArgs e)
        {

            Admin_Dashboard adb = new Admin_Dashboard();
            adb.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
           
            txtitemnumber.Text = "";
            txtitemname.Text = "";
            txtitemdescription.Text = "";
            txtunitprice.Text = "";

            updownquantity.Value = 0;
            dtpdate.Value = DateTime.Now;
        }

        private void Add_Item_of_Stock_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
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

                    txtitemnumber.Text = dr["Item_Number"].ToString();
                    txtitemname.Text = dr["Item_Name"].ToString();
                    txtitemdescription.Text = dr["Description"].ToString();
                    dtpdate.Text = dr["Date"].ToString();
                    updownquantity.Text = dr["Quantity"].ToString();
                    txtunitprice.Text = dr["Unit_Price"].ToString();
                }
                else
                {
                    MessageBox.Show("Entered Item Number doesn't exists", "Quantum_Quest_Database_Management_System",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                if (txtitemnumber.Text == "" || txtitemname.Text == "" || txtitemdescription.Text == "" || dtpdate.Text == "" || updownquantity.Text == "" || txtunitprice.Text == "")
                {
                    MessageBox.Show("Invalid Input, Empty fields are not acceptable", "Quantum_Quest_Database_Management_System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void pblogo_Click(object sender, EventArgs e)
        {
            Admin_Dashboard adb = new Admin_Dashboard();
            adb.Show();
            this.Hide();
        }

        private void btnviewtransactionlog_Click(object sender, EventArgs e)
        {
            Transaction_Log_Form transactionLogForm = new Transaction_Log_Form();
            transactionLogForm.Show();
            this.Hide();
        }

        private void btnviewtransactionlog_Click_1(object sender, EventArgs e)
        {
            Transaction_Log_Form tlf = new Transaction_Log_Form();
            tlf.Show();
            this.Hide();
        }
    }
}
