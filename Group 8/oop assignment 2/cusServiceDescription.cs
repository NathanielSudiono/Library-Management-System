using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_assignment_2
{
    public partial class cusServiceDescription : Form
    {
        private string username;
        public cusServiceDescription()
        {
            InitializeComponent();
        }
        public cusServiceDescription(string un)
        {
            InitializeComponent();
            username = un;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            cusNameLbl.Text = username;
            DataTable Service = new DataTable();//create table
            Service = Order.ViewService(username);//call the method and store the value into the table
            dgvServiceDescription.DataSource = Service;
        }

        private void cusBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cusBackForm = new cusMenu(username);
            cusBackForm.Show();
        }

        private void cusNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
