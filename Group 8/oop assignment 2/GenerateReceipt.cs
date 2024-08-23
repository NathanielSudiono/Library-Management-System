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
    public partial class GenerateReceipt : Form
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public GenerateReceipt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int servID = -1;
            string urgency =" ";
            string servName =" ";
            int fee = -1;


            con.Open();
            SqlCommand command = new SqlCommand("select fullname, services,urgency from customers where username = '"+ textUsername.Text+ "'",con);
            SqlDataReader srd = command.ExecuteReader();
            while (srd.Read())
            {
                fullnameTxt.Text = srd.GetValue(0).ToString();
                servID = int.Parse(srd.GetValue(1).ToString());
                urgency = srd.GetValue(2).ToString();
                    

            }
            srd.Close();   
            SqlCommand command3 = new SqlCommand("select serviceName from service where ServiceID = '" + servID + "'", con); 
            SqlDataReader srd3 = command3.ExecuteReader();
            while (srd3.Read())
            {
                servicesTxt.Text = srd3.GetValue(0).ToString();
                servName = srd3.GetValue(0).ToString();
            }
           
            srd3.Close();
            SqlCommand command5 = new SqlCommand("update orders set orderType = '"+ servName+ "' where name ='" + fullnameTxt.Text + "'", con);
            command5.ExecuteNonQuery();


            srd3.Close();
            if (urgency == "normal" || urgency == "Normal" || urgency == "NORMAL")
            {
                SqlCommand command2 = new SqlCommand("select CostNormal from service where ServiceName = '" + servicesTxt.Text + "'", con);
                SqlDataReader srd2 = command2.ExecuteReader();
                while (srd2.Read())
                {
                    feeTxt.Text = srd2.GetValue(0).ToString();
                    fee = (int)srd2.GetValue(0);

                }

                srd2.Close();
                SqlCommand command6 = new SqlCommand("update orders set fee = '"+fee+"'where name ='"+ fullnameTxt.Text + "'", con);
                command6.ExecuteNonQuery();
            }
            else if (urgency == "urgent" || urgency == "Urgent" || urgency == "URGENT")
            {
                SqlCommand command4 = new SqlCommand("select CostUrgent from service where servicename ='" + servicesTxt.Text + "'", con);
                SqlDataReader srd4 = command4.ExecuteReader();
                while (srd4.Read())
                {
                    feeTxt.Text = srd4.GetValue(0).ToString();
                }

                srd4.Close();
                SqlCommand command7 = new SqlCommand("update orders set fee = '" + fee + "'where name ='" + fullnameTxt.Text + "'", con);

                command7.ExecuteNonQuery();
            }
            con.Close();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print successful");
            this.Close();
        }

        private void GenerateReceipt_Load(object sender, EventArgs e)
        {

        }
    }
}
