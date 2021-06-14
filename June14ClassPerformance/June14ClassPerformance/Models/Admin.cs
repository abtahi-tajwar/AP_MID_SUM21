using June14ClassPerformance.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace June14ClassPerformance.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool verifyAdmin(Admins admins)
        {
            Admin admin  = admins.getAdmin(this.Username);
            if (admin != null)
            {
                if (admin.Password == this.Password)
                {
                    return true;
                }
                return false;
            } 
            return false;
        }
    }

}