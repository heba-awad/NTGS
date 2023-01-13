using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NTGS.Models.DBContext
{
    public class NTGSContext : DbContext 
    {
        public NTGSContext() : base("name=NTGS_DBConnectionString")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}