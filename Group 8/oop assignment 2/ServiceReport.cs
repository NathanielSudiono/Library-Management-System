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
    public partial class ServiceReport : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\oop assignment 2\oop assignment 2\myDB.mdf;Integrated Security=True";
            
        public ServiceReport()
        {
            InitializeComponent();
        }

        private void BckBtn_Click(object sender, EventArgs e)
        {
            AdminMenu form = new AdminMenu();
            form.ShowDialog();
        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        } 

        private void Form4_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT orderType,urgencyLevel,name,status,description,collectionDate FROM Orders", sqlCon);
                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataTable.DataSource = dtbl;
            }
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
