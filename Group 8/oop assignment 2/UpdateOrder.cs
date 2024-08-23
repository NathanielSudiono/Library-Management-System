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
    public partial class UpdateOrder : Form
    {
        string name;
        string serviceType;

        public UpdateOrder()
        {
            InitializeComponent();
        }

        public UpdateOrder(string n, string service)
        {
            InitializeComponent();
            serviceType = service;
            name = n;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseOrder co = new ChooseOrder();
            co.ShowDialog();

        }

        private void UpdateOrder_Load(object sender, EventArgs e)
        {
            lblNameDetail.Text = name;
            lblServiceDetail.Text = serviceType;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure to update this order ?", "confirm update", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Order ord1 = new Order(lblNameDetail.Text, lblServiceDetail.Text, txtDescription.Text, dtpCollectionDate.Value.ToString());
                MessageBox.Show(ord1.UpdateOrder());
                this.Hide();
                ChooseOrder co = new ChooseOrder();
                co.ShowDialog();
            }
            else
            {
                this.Hide();
                ChooseOrder co = new ChooseOrder();
                co.ShowDialog();//go back to choose order
            }

            
        }
    }
}
