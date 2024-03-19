using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Hotel_Mangement_System
{
    public partial class Form1 : Form
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DELL\Desktop\neha things\Hotel Mangement System\Database\Hotel Database.mdf"";Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textboxUsername.Text.ToString();
            string password = textboxpassword.Text.ToString();
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                DialogResult dialogResult = MessageBox.Show("No empty field allow", "You cannot continue", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user_table WHERE username='" + username + "' AND password='" + password + "' ";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    FormHome form = new FormHome();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                }
                //  MessageBox.Show("Connection Succeed!");
                //conn.Close();t 


            }

        }

        private void textboxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
