using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_assignment_2
{
    public partial class PendingOrder : Form
    {
        private static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public PendingOrder()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TechnicianMenu tm = new TechnicianMenu();
            tm.ShowDialog();
        }

        private void PendingOrder_Load(object sender, EventArgs e)
        {
            DataTable PendingOrders = new DataTable();//create table
            PendingOrders = Order.ViewPendingOrders();//call the method and store the value into the table
            dgvPendingOrders.DataSource = PendingOrders;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dgvPendingOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
