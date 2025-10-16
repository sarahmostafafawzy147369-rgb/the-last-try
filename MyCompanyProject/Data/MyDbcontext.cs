using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MyCompanyProject.Models;

namespace MyCompanyProject.Data
{
    public class MyDbcontext : DbContext
    {
        public DbSet<Car> Car { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Admin> Admin { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=MyCompany;Integrated Security=True;Trust Server Certificate=True");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Department>().HasKey(s => new { s.Student_Id, s.course_Id });

        //}
       
    }
}
