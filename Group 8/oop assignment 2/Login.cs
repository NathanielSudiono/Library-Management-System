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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblNameDetail_Click(object sender, EventArgs e)
        {

        }

        private void lblService_Click(object sender, EventArgs e)
        {

        }

        private void lblServiceDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            string response; 
            User obj1 = new User(txtUsername.Text, txtPassword.Text);
            response = obj1.login(txtUsername.Text); //call method login from class user
            if (response != null)
            {
                MessageBox.Show(response); 
            }
            txtUsername.Text = String.Empty; //empty the username and password textbox
            txtPassword.Text = String.Empty;
        }
    }
}
