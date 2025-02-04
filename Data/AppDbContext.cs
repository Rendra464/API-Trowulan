using Microsoft.EntityFrameworkCore;
using TrowulanForm.Models;

namespace TrowulanForm.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Registration> Registrations { get; set; }
        public DbSet<GetinTouch> GetinTouch { get; set; }
        
    }
}
