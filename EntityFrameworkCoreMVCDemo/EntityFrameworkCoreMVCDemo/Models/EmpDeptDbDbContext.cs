using Microsoft.EntityFrameworkCore;
using EntityFrameworkCoreMVCDemo.Models;

namespace EntityFrameworkCoreMVCDemo.Models
{
    public class EmpDeptDbDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\sqlexpress;Trusted_Connection=True;Database=EmpDeptDb;TrustServerCertificate=True");
        }
        //dbset is used to create table in database
        //dataset is the client side representation of the table in database
        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
        //public DbSet<EntityFrameworkCoreMVCDemo.Models.EmployeeVm> EmployeeVm { get; set; } = default!;


    }
}
