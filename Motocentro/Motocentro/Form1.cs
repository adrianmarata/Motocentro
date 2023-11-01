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

namespace Motocentro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string connectionString = "Data Source=HAPI\\SQLEXPRESS;Initial Catalog=Motocentro;Integrated Security=True;";



        private void buttonProducts_Click(object sender, EventArgs e)
        {
            panelContents.Controls.Clear();

            Products product = new Products();
            product.TopLevel = false;
            panelContents.Controls.Add(product);
            product.Dock = DockStyle.Fill;
            product.Show();
        }

        private void buttonAccounts_Click(object sender, EventArgs e)
        {
            panelContents.Controls.Clear();

            Accounts account = new Accounts();
            account.TopLevel = false;
            panelContents.Controls.Add(account);
            account.Dock = DockStyle.Fill;
            account.Show();
        }
    }
}
