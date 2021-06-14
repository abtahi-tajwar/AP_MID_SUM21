using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace June14ClassPerformance.Models.Database
{
    public class Admins
    {
        SqlConnection conn;
        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        public Admin getAdmin(string username)
        {
            string query = "SELECT * FROM Admins WHERE username = '" + username + "'";
            SqlCommand cmd = new SqlCommand(query, this.conn);
            this.conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Admin admin = new Admin()
            {
                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                Name = reader.GetString(reader.GetOrdinal("Name")),
                Username = reader.GetString(reader.GetOrdinal("Username")),
                Password = reader.GetString(reader.GetOrdinal("Password")),
            };
            return admin;
        }
    }
    
}