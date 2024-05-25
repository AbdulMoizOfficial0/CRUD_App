using CRUD_App.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
