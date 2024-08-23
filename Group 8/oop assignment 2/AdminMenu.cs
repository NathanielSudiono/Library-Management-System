namespace oop_assignment_2
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void RegTBtn_Click(object sender, EventArgs e)
        {
            RegisterTechnichian form2 = new RegisterTechnichian();
            form2.ShowDialog();
        }

        private void RegRBtn_Click(object sender, EventArgs e)
        {
            RegisterReceptionist form3 = new RegisterReceptionist();
            form3.ShowDialog();
        }

        private void MrepBtn_Click(object sender, EventArgs e)
        {
            ServiceReport form4 = new ServiceReport();
            form4.ShowDialog();
        }


        private void MinBtn_Click(object sender, EventArgs e)
        {
            Income form5 = new Income();
            form5.ShowDialog();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }
    }
}