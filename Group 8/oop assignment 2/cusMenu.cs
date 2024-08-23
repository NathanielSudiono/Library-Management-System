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
    public partial class cusMenu : Form
    {
        private string username;
        public cusMenu()
        {
            InitializeComponent();
        }
        public cusMenu(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void cusProfileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cusProfileForm = new cusProfile(username);
            cusProfileForm.Show();
        }

        private void cusViewBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cusServiceDescriptionForm = new cusServiceDescription(username);
            cusServiceDescriptionForm.Show();
        }

        private void cusChangeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cusChangeServicesForm = new cusChangeServices(username);
            cusChangeServicesForm.Show();
        }

        private void cusBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new Login();
            loginForm.Show();
        }

        private void cusNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void cusMenu_Load(object sender, EventArgs e)
        {
            cusNameLbl.Text = username;
        }
    }
}