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
    public partial class cusProfile : Form
    {
        private string username;
        public cusProfile()
        {
            InitializeComponent();
        }
        public cusProfile(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void cusBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cusBackForm = new cusMenu(username);
            cusBackForm.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string Newusername = usernameTxt.Text;
            string password = passwordTxt.Text;
            string email = emailTxt.Text;

            if (Newusername.Equals(""))
            {
                MessageBox.Show("Incomplete input");
                var cusUpdateForm = new cusMenu(username);
                cusUpdateForm.Show();
                this.Close();
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Incomplete input");
                var cusUpdateForm = new cusMenu(username);
                cusUpdateForm.Show();
                this.Close();
            }
            else if (email.Equals(""))
            {
                MessageBox.Show("Incomplete input");
                var cusUpdateForm = new cusMenu(username);
                cusUpdateForm.Show();
                this.Close();
            }
            else
            {
                User obj1 = new User(Newusername, passwordTxt.Text, emailTxt.Text, username);
                string status = obj1.updateProfile();
                MessageBox.Show(status);
                this.Hide();
                Login login = new Login();
                login.Show();
                
                
                
                
                
                
                
                

                
                
            }
            

            
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cusProfile_Load(object sender, EventArgs e)
        {
            cusNameLbl.Text = username;
        }

        private void cusNameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
