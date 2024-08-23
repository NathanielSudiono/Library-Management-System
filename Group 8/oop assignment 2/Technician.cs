using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;

namespace oop_assignment_2
{
    class Technician
    {
        private string username;
        private string Fullname;
        private string Birthday;
        private string Email;
        private string Password;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Birthday1 { get => Birthday; set => Birthday = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string username1 { get => username; set => username = value; }
        public string Fullname1 { get => Fullname; set => Fullname = value; }
        public string Password1 { get => Password; set => Password = value; }

        public Technician(string u,string f,string b,string e,string pn)
        {
            username = u;
            Fullname = f;
            Birthday = b;
            Email = e;
            Password = pn;
        }
        public string RegisterTechnician()
        {
            string status;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("insert into Users(Username,Password,Role,Email,Fullname,Birthday) values(@username,@Password,'Technician',@Email,@Fullname,@Birthday)", con);
            cmd2.Parameters.AddWithValue("Username", username);
            cmd2.Parameters.AddWithValue("Password", Password);
            cmd2.Parameters.AddWithValue ("Email", Email);
            cmd2.Parameters.AddWithValue("Fullname",Fullname);
            cmd2.Parameters.AddWithValue("BirthDay", Birthday);
            
            cmd2.ExecuteNonQuery();
            if (username == "" || Fullname == "" || Birthday == "" || Email == "" || Password == "")
                status = "Please fill mandatory field";
            else
                status = "Register Successful";
            con.Close();
            return status;
        }
    }
}
//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\assignment\assignment\Database1.mdf;Integrated Security=True