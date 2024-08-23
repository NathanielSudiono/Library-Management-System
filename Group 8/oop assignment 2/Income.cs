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

namespace oop_assignment_2
{
    public partial class Income : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\oop assignment 2\oop assignment 2\myDB.mdf;Integrated Security=True";
        public Income()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            AdminMenu frm = new AdminMenu();
            frm.ShowDialog();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT orderType,description,collectionDate,fee FROM Orders", sqlCon);
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                Data2Table.DataSource = dtbl;
            }
        }

        private void Data2Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Data2Table.AllowUserToAddRows = false;
        }

        private void TotalBtn_Click(object sender, EventArgs e)
        {
            Admin admin1 = new Admin();
            string total = admin1.income();
            Total.Text = total;
        }

        private void TableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
