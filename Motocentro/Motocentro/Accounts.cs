using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Motocentro
{
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=HAPI\\SQLEXPRESS;Initial Catalog=Motocentro;Integrated Security=True;";

        private void Accounts_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT Name, Phone_Number as 'Phone Number', Loyalty_Points as 'Loyalty Points' FROM Accounts", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);

                dataGridViewAccounts.DataSource = dt;
            }

            dataGridViewAccounts.ReadOnly = true;
        }
        public void RefreshDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT Name, Phone_Number as 'Phone Number', Loyalty_Points as 'Loyalty Points' FROM Accounts", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dataGridViewAccounts.DataSource = dt;
            }
            dataGridViewAccounts.ReadOnly = true;
        }
        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search for Accounts")
            {
                textBoxSearch.Text = "";
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                textBoxSearch.Text = "Search for Accounts";
            }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string searchTerm = textBoxSearch.Text;
                string searchQuery = "SELECT Name, Phone_Number as 'Phone Number', Loyalty_Points as 'Loyalty Points' FROM Accounts WHERE Name LIKE @searchTerm";

                using (SqlCommand command = new SqlCommand(searchQuery, conn))
                {
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        dataGridViewAccounts.DataSource = dataTable;
                    }
                }
            }
        }

        private void buttonAdd_MouseEnter(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.LightGray;
        }

        private void buttonAdd_MouseLeave(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.White;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.RefreshRequest += RefreshDataGridView;
            addAccount.ShowDialog();
        }
    }
}
