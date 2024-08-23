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
using System.Configuration;

namespace oop_assignment_2
{
    public partial class RegisterTechnichian : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\assignment\assignment\myDB.mdf;Integrated Security=True";
        public RegisterTechnichian()
        {
            InitializeComponent();
        }

        private void ConBtn_Click(object sender, EventArgs e)
        {
            Technician obj1 = new Technician(userTxt.Text, NameTxt.Text,BirthTxt.Text, MailTxt.Text, PassTxt.Text);
            MessageBox.Show(obj1.RegisterTechnician());
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminMenu form1 = new AdminMenu();
            form1.ShowDialog();
        }

        private void RegisterTechnichian_Load(object sender, EventArgs e)
        {

        }
    }
}
