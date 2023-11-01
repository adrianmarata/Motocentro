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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }


        string connectionString = "Data Source=HAPI\\SQLEXPRESS;Initial Catalog=Motocentro;Integrated Security=True;";

        private void Products_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT Name, Category, Sell_Price as 'Price', Quantity, Model FROM PRODUCTS", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);

                dataGridViewProducts.DataSource = dt;
                conn.Close();
            }

            dataGridViewProducts.ReadOnly = true;
        }
    }
}
