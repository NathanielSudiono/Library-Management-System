using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2
{
    internal class Order
    {
        private string OrderID;
        private string CustomerName;
        private string OrderFee;
        private string OrderType;
        private string urgency;
        private string OrderStatus;
        private string Description;
        private string CollectionDate;

        private static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Order(string cn, string ot, string d, string cd)
        {
            CustomerName = cn;
            OrderType = ot;
            Description = d;
            CollectionDate = cd;
        }

        public static DataTable ViewPendingOrders()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select OrderID, orderType, urgencyLevel, name from Orders where status = 'Ongoing'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();//create table
            da.Fill(dt);//fill the table with selected data
            con.Close();
            return dt;
        }

        public static ArrayList TakePendingOrders()
        {
            ArrayList nm = new ArrayList();//create dynamic arrray
            con.Open();
            SqlCommand cmd = new SqlCommand("select OrderID from Orders where status ='ongoing'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nm.Add("Order ID - " + dr.GetInt32(0));//add the IDs according to each record found to araray
            }
            con.Close();
            return nm;
        }

        public static ArrayList ShowDetails(char selectedOrder)
        {
            ArrayList nm = new ArrayList();//create dynamic array
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Orders where OrderID ='" + selectedOrder + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                nm.Add(dr.GetString(1));//add the name, order type, andd urgency level from each found records and store in array
                nm.Add(dr.GetString(2));
                nm.Add(dr.GetString(3));
            }
            con.Close();
            return nm;
        }

        public string UpdateOrder()
        {
            string status;
            con.Open();
            //update the status, description and collection date
            SqlCommand cmd = new SqlCommand("update Orders set status = 'completed', " +
                "description ='" + Description + "', collectionDate ='" + CollectionDate + "' " +
                "where name='" + CustomerName + "' and orderType ='" + OrderType + "'", con);
            int i = cmd.ExecuteNonQuery(); //store the amount of times the row was affected
            if (i == 0)
                status = "Order Failed to Update";
            else
                status = "Order Updated";
            con.Close();
            return status;
        }

        public static DataTable ViewService(string username)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Orders where name = '"+username+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();//create table
            da.Fill(dt);//fill the table with selected data
            con.Close();
            return dt;
        }
    }
}
