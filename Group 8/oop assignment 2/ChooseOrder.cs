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
    public partial class ChooseOrder : Form
    {
        public ChooseOrder()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            TechnicianMenu tm = new TechnicianMenu();
            tm.ShowDialog(); 
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

            if (lblNameResult.Text  == "") 
            {
                MessageBox.Show("There is no selected order details", " something went wrong!!! "); 
            }
            else
            {
                this.Hide();
                UpdateOrder up = new UpdateOrder(lblNameResult.Text, lblServiceResult.Text); 
                up.ShowDialog();
            }
        }

        private void ChooseOrder_Load(object sender, EventArgs e)
        {
            ArrayList orders = new ArrayList(); //create array
            orders = Order.TakePendingOrders(); //call TakePendingOrders() method and store the return value in array orders

            foreach (var item in orders)
            {
                cmbPendingService.Items.Add(item); //add the value to the combobox items
            }

            if (cmbPendingService.Items.Count == 0) 
            {
                cmbPendingService.Text = "No pending orders";
            }
        }

        private void cmbPendingService_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList details = new ArrayList(); //create array
            string order = cmbPendingService.SelectedItem.ToString();
            char orderID = order[11]; //to get the OrderId from the string element "order ID - orderID"
            details = Order.ShowDetails(orderID);//call the method by sending the OrderId in char data type as an argument

            lblNameResult.Text = details[2].ToString(); //make the labels text according to their respective value from the array
            lblUrgencyResult.Text = details[1].ToString();
            lblServiceResult.Text = details[0].ToString();
        }
    }
}
