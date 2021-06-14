using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace June14ClassPerformance.Models.Database
{
    public class Departments
    {
        SqlConnection conn;
        public Departments(SqlConnection conn)
        {
            this.conn = conn;
        }
    }
}