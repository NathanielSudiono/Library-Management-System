using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace oop_assignment_2
{
    internal class Receptionist
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

        public Receptionist(string u, string f, string e,string b, string pn)
        {
            username = u;
            Fullname1 = f;
            Birthday = b;
            Email = e;
            Password = pn;
        }
        public string RegisterReceptionist()
        {
            string status;
            con.Open();
            SqlCommand cmd2 = new SqlCommand("insert into Users(Username,Password,Role,Email,Fullname,Birthday) values(@username,@Password,'Receptionist',@Email,@Fullname,@Birthday)", con);
            cmd2.Parameters.AddWithValue("Username", username);
            cmd2.Parameters.AddWithValue("Password", Password);
            cmd2.Parameters.AddWithValue("Email", Email);
            cmd2.Parameters.AddWithValue("Fullname", Fullname);
            cmd2.Parameters.AddWithValue("Birthday", Birthday);

            cmd2.ExecuteNonQuery();
            if(username == "" || Fullname == "" || Birthday == "" || Email == "" || Password == "")
                status = "Please fill mandatory field";
            else
                status = "Register Successful";
            con.Close();
            return status;
        }
    }
}
