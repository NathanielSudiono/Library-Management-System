using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2
{
    internal class User
    {
        private string username;
        private string password;
        private string fullName;
        private string email;
        private string birthday;
        private string Oldusername;

        private static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public User(string un, string p)
        {
            username = un;
            password = p;
        }

        public User(string u, string p, string e, string ou)
        {
            username = u;
            password = p;
            email = e;
            Oldusername = ou;
        }
        public string login(string un)
        {
            string status = null; 
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            //find how many rows matched the username and password
            SqlCommand cmd = new SqlCommand("select count(*) from users where username= '" + username + "'and password ='" + password + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar()); //convert the number of times the row were affected and store it in count

            if (count > 0) //there is valid record in the database
            {
                //check the user's role
                SqlCommand cmd2 = new SqlCommand("select role from users where username= '" + username + "'and password ='" + password + "'", con);
                string role = cmd2.ExecuteScalar().ToString();//convert the fousnd role to string and store it in role

                if (role == "Customer")
                {
                    cusMenu cm = new cusMenu(un);
                    cm.ShowDialog();
                }
                else if (role == "Receptionist")
                {
                    ReceptionistMenu rm = new ReceptionistMenu(un);
                    rm.ShowDialog();
                    
                }
                else if (role == "Technician")
                {
                    TechnicianMenu tm = new TechnicianMenu(un);
                    tm.ShowDialog();
                    
                }
                else if (role == "Admin")
                {
                    AdminMenu rm = new AdminMenu();
                    rm.ShowDialog();
                }
            }
            else
                status = "login failed, incorrect username or password";
            con.Close();

            return status;
        }

        public string updateProfile()
        {
            string status;
            string role;

            con.Open();

            SqlCommand cmd = new SqlCommand("update Users set email ='" + email + "',username = '" + username + "',password = '" + password + "' where username ='" + Oldusername + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                status = "Update Successfully.";
            else
                status = "Unable to update.";

            SqlCommand cmd2 = new SqlCommand("select role From Users where username='" + Oldusername + "'", con);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                role = dr.GetString(0);
                if (role == "Customer")
                {
                    SqlCommand cmd3 = new SqlCommand("update Customers set email ='" + email + "',username = '" + username + "',password = '" + password + "' where username ='" + Oldusername + "'", con);
                    cmd3.ExecuteNonQuery();
                }
            }
            con.Close();
            return status;
        }
    }
}
