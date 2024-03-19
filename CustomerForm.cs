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

namespace Hotel_Mangement_System
{
    public partial class CustomerForm : Form
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DELL\Desktop\neha things\Hotel Mangement System\Database\Hotel Database.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();



        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            showDataCustomer();
        }

        private void showDataCustomer()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("select * from Customer", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllCustomers.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string CustomerName, CustomerPhone, CustomerEmail, CustomerID;
            CustomerName = textBoxCustName.Text.ToString();
            CustomerPhone = textBoxCustPhone.Text.ToString();
            CustomerEmail = textBoxCustEmail.Text.ToString();
            CustomerID = textBoxCustId.Text.ToString();
            if (String.IsNullOrEmpty(CustomerName) || String.IsNullOrEmpty(CustomerPhone) || String.IsNullOrEmpty(CustomerID))
            {
                MessageBox.Show("No Empty Fields Are Allowed except Email Address of the customer");
            }
            else
            {



                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "INSERT INTO Customer (CustomerName,CustomerPhone,CustomerEmail ) VALUES ('" + CustomerName + "','" + CustomerPhone + "','" + CustomerEmail + "')";
                cmd.Connection = conn;

                int a = cmd.ExecuteNonQuery();
                conn.Close();
                if (a > 0)
                {
                    MessageBox.Show("Customer has successfully Registered!");
                    textBoxCustPhone.Text = " ";
                    textBoxCustEmail.Text = " ";
                    textBoxCustId.Text = " ";
                }
            }
        }

        private void dataGridViewAllCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool idSearchSelected = radioButtonIdentity.Checked;
            bool nameSearchSelected = radioButtonName.Checked;
            bool phoneSearchSelected = radioButtonphone.Checked;
            conn.ConnectionString = CONNECTION_STRING;
            // SqlCommand cmd = new SqlCommand();
            string textToSearch = textBoxSearch.Text.ToString();
            if (idSearchSelected)
            {
                //MessageBox.Show("Identity Search was Selected");
                adpt = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerID='" + textToSearch + "'", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;
            }
            else if (nameSearchSelected)
            {
                try
                {
                    adpt = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerName='" + textToSearch + "'", conn);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridViewSearchResult.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (phoneSearchSelected)
            {
                adpt = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerPhone='" + textToSearch + "'", conn);
                dt = new DataTable();
                adpt.Fill(dt);
                dataGridViewSearchResult.DataSource = dt;
            }
        }

        private void button4delete_Click(object sender, EventArgs e)
        {
            string CustomerID = textBoxCustId.Text.ToString();

            if (String.IsNullOrEmpty(CustomerID))
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "DELETE FROM Customer WHERE CustomerID = '" + CustomerID + "'";
                cmd.Connection = conn;

                int a = cmd.ExecuteNonQuery();
                conn.Close();
                if (a > 0)
                {
                    MessageBox.Show("Customer deleted successfully!");
                    showDataCustomer(); // Refresh the grid
                }
            }
        }

        private void button3update_Click(object sender, EventArgs e)
        {
            string CustomerName, CustomerPhone, CustomerEmail, CustomerID;
            CustomerName = textBoxCustName.Text.ToString();
            CustomerPhone = textBoxCustPhone.Text.ToString();
            CustomerEmail = textBoxCustEmail.Text.ToString();
            CustomerID = textBoxCustId.Text.ToString();

            if (String.IsNullOrEmpty(CustomerID))
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            conn.ConnectionString = CONNECTION_STRING;
            conn.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UPDATE Customer SET CustomerName = '" + CustomerName + "', CustomerPhone = '" + CustomerPhone + "', CustomerEmail = '" + CustomerEmail + "' WHERE CustomerID = '" + CustomerID + "'";
            cmd.Connection = conn;

            int a = cmd.ExecuteNonQuery();
            conn.Close();
            if (a > 0)
            {
                MessageBox.Show("Customer information updated successfully!");
                showDataCustomer(); // Refresh the grid
            }
        }
    }
    }

        
    

