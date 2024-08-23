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
    public partial class RegisterCustomer : Form
    {
       
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Customers obj1 = new Customers(userTxt.Text, passTxt.Text, fullTxt.Text, emailTxt.Text,  birthdayTxt.Text, servicesTxt.Text, urgencyTxt.Text);
            MessageBox.Show(obj1.addCustomers());
            MessageBox.Show("Registration Success");
        }
      

        private void btnRegister2_Click(object sender, EventArgs e)
        {
            if(userTxt.Text == " " || passTxt.Text == " " || fullTxt.Text == " " || emailTxt.Text == " " ||  birthdayTxt.Text == " " || servicesTxt.Text == " " || urgencyTxt.Text == " ")
            {
                MessageBox.Show("Please fill all required fields");
            }
            else
            {
                Customers obj1 = new Customers(userTxt.Text, passTxt.Text, fullTxt.Text, emailTxt.Text, birthdayTxt.Text, servicesTxt.Text, urgencyTxt.Text);
                MessageBox.Show(obj1.addCustomers());
            }

            


            
        }

        private void serviceList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblServices_Click(object sender, EventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void urgencyTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}