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
    public partial class ReceptionistMenu : Form
    {
        //string connectionString = @"Data Source = C:\Users\Owen\Desktop\OOP ASSIGNMENT\OOP Assignment\OOP Assignment\myDB.mdf;Initial Catalog = myDB; Integrated Security = True";

        private string username;

        public ReceptionistMenu()
        {
            InitializeComponent();


        }

        public ReceptionistMenu(string un)
        {
            InitializeComponent();
            username = un;

        }

        private void open_form_btn(Form formname)
        {
            formname.ShowDialog();
        }
        private void click_btn(Button btn)
        {

            Button[] buttons = { RegCustbtn, CompOrderbtn , Updatebtn,  };
        }
       

        private void RegCustbtn_Click(object sender, EventArgs e)
        {
            RegisterCustomer f2 = new RegisterCustomer();
            f2.Show();
        }

        private void CompOrderbtn_Click(object sender, EventArgs e)
        {
            click_btn(CompOrderbtn);

            Form GenerateReceiptForm = new GenerateReceipt();
            open_form_btn(GenerateReceiptForm);
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            cusProfile updateProfile = new cusProfile(username);
            updateProfile.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ReceptionistMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
