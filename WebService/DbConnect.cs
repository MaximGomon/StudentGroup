using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebService
{
    public class DbConnect : DbContext
    {
        public DbConnect() : base("DBConnection")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}