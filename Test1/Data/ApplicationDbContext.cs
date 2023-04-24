using Microsoft.EntityFrameworkCore;
using Test1.Models;

namespace Test1.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {

        }
        public DbSet<Address> Address { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
