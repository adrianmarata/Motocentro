using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motocentro
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=HAPI\\SQLEXPRESS;Initial Catalog=Motocentro;Integrated Security=True;";
        public event Action RefreshRequest;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string addQuery = "INSERT INTO Accounts(Name, Phone_Number) VALUES (@Value1, @Value2)";
                SqlCommand command = new SqlCommand(addQuery, conn);    
                command.Parameters.AddWithValue("@Value1", textBoxName.Text);
                command.Parameters.AddWithValue("@Value2", textBoxPhoneNumber.Text);
                command.ExecuteNonQuery();
                RefreshRequest?.Invoke();
            }
        }
    }
}
