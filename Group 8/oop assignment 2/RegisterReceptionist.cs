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
    public partial class RegisterReceptionist : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\oop assignment 2\oop assignment 2\myDB.mdf;Integrated Security=True";
        public RegisterReceptionist()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receptionist obj2 = new Receptionist(User2Txt.Text, Name2Txt.Text, Birth2Txt.Text, Mail2Txt.Text, Pass2Txt.Text);
            MessageBox.Show(obj2.RegisterReceptionist());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu frm = new AdminMenu();
            frm.ShowDialog();
        }

        private void RegisterReceptionist_Load(object sender, EventArgs e)
        {

        }
    }
}
