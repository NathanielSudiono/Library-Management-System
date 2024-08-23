using System;
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
    public partial class cusChangeServices : Form
    {
        private string username;
        public cusChangeServices()
        {
            InitializeComponent();
        }
        public cusChangeServices(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void cusBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cusMenuForm = new cusMenu(username);
            cusMenuForm.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //string newServices = changeToLb.Text;
            string newServices = changeToLb.SelectedItem.ToString();
            // gimana yah biar bisa null
            MessageBox.Show(newServices);
            if (newServices != null)
            {
                Customers obj1 = new Customers(newServices, username);
                MessageBox.Show(obj1.changeServices());
                this.Hide();
                var cusMenuForm = new cusMenu(username);
                cusMenuForm.Show();
            }
            else
            {
                MessageBox.Show("No Services Selected!!!");
                this.Hide();
                var cusMenuForm = new cusMenu(username);
                cusMenuForm.Show();
            }

        }

        private void changeToLb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cusChangeServices_Load(object sender, EventArgs e)
        {
            cusNameLbl.Text = username;
        }
    }
}
