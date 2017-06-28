using Employee.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("EmployeeEntity") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DataContext>(null);

            base.OnModelCreating(modelBuilder);
        }

        // employee entities
        public DbSet<EmployeeDetail> EmployeeDetails { get; set; }

       
    }
}
