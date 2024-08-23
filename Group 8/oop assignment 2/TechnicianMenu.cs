namespace oop_assignment_2
{
    public partial class TechnicianMenu : Form
    {
        private string username;

        public TechnicianMenu()
        {
            InitializeComponent();
        }

        public TechnicianMenu(string un)
        {
            InitializeComponent();
            username = un;
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            PendingOrder po = new PendingOrder();
            po.ShowDialog();
            this.Close();
        }

        private void btnUpdaterder_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseOrder co = new ChooseOrder();
            co.ShowDialog();
            this.Close();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            cusProfile updateProfile = new cusProfile(username);
            updateProfile.ShowDialog();
            this.Close();
        }

        private void TechnicianMenu_Load(object sender, EventArgs e)
        {

        }
    }
}