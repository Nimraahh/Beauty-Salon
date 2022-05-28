using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Data.SqlClient;
namespace WebApplication2.Models
{
    public class data
    {
        public bool AddUser(user user)
        {
            if (!SearchUser(user))
            {
                string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=user;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string query = $"Insert into salonLogin (username,password,name,email,phone,city) values('{user.userName}','{user.password}','{user.Name}','{user.mail}','{user.phone}','{user.city}')";
                SqlCommand cmd = new SqlCommand(query, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                return (rowsAffected == 1 ? true : false);
            }
            else return false;

        }
        public bool SearchUser(user user)
        {
            string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=user;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string query = $"Select * from salonLogin where username = '{user.userName}' and password = '{user.password}'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return (dr.HasRows ? true : false);
        }
        public List<user> GetAllData()
        {
            List<user> AllUsers = new List<user>();
            string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=user;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            string query = "Select * from salonLogin";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    user user = new user();
                    user.Id = Convert.ToInt32(dr[0]);
                    user.userName = Convert.ToString(dr[1]);
                    user.password = Convert.ToString(dr[2]);
                    user.mail = Convert.ToString(dr[3]);
                    user.Name = Convert.ToString(dr[4]);
                    user.phone = Convert.ToString(dr[5]);
                    user.city = Convert.ToString(dr[6]);
                    AllUsers.Add(user);
                }
            }
            return AllUsers;
        }

    }
}
