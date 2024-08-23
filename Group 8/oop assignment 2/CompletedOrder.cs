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
    public partial class CompletedOrder : Form
    {
        public CompletedOrder()
        {
            InitializeComponent();
        }
        private void GenRecbtn_Click(object sender, EventArgs e)
        {
           GenerateReceipt f2 = new GenerateReceipt();
            f2.ShowDialog();
        }

        private void CompletedOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
