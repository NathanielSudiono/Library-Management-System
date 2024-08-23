using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;

namespace oop_assignment_2
{
    internal class Customers
    {
        private string username;
        private string password;
        private string fullName;
        private string email;
        private string birthday;
        private string services;
        private string Urgency;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Services { get => services; set => services = value; }

        public Customers(string u, string p, string f, string e, string b, string s, string urgency)
        {
            username = u;
            password = p;
            fullName = f;
            email = e;
            birthday = b;
            services = s;
            Urgency = urgency;
        }


        public Customers(string s, string u)
        {
            services = s;
            username = u;
        }


        public string changeServices()
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("update customers set services ='" + services + "' where username ='" + username + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";
            con.Close();

            return status;
        }

        public string addCustomers()
        {

            string status;
            con.Open();



            SqlCommand cmd = new SqlCommand("insert into customers(username,password,fullname,email,birthday,services,urgency)values (@user,@pass,@full,@em,@birth,@ser,@urgency)", con);
            SqlCommand cmd2 = new SqlCommand("insert into users(username,password,role,email,fullname,birthday) values (@user,@pass,'Customers',@em,@full,@birthdate)", con);
            SqlCommand cmd3 = new SqlCommand("insert into Orders(status,urgencyLevel,name) values ('Ongoing', @urgency, @full)", con);
            cmd.Parameters.AddWithValue("@user", username);
            cmd2.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd2.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@full", fullName);
            cmd2.Parameters.AddWithValue("@full", fullName);
            cmd3.Parameters.AddWithValue("@full", fullName);
            cmd.Parameters.AddWithValue("@em", email);
            cmd2.Parameters.AddWithValue("@em", email);
            cmd.Parameters.AddWithValue("@birth", birthday);
            cmd2.Parameters.AddWithValue("@birthdate", birthday);
            cmd.Parameters.AddWithValue("@ser", services);
            cmd.Parameters.AddWithValue("@urgency", Urgency);
            cmd3.Parameters.AddWithValue("@urgency", Urgency);
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Registration Successful.";
            else
                status = "Unable to Register.";
            con.Close();
            return status;
        }
    }
}
