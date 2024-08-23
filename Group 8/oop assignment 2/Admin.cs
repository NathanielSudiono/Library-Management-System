using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace oop_assignment_2
{
    internal class Admin
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\assignment\assignment\myDB.mdf;Integrated Security=True";
        
        public string income()
        {
            string Total = null;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM (fee) FROM Orders", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
            Total = reader.GetInt32(0).ToString();
            }
            con.Close();
            return Total;
        }
    }
    
}
