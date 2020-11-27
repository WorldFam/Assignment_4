using Assignment_3_API.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Assignnment_4_API.DataAccess
{
    public class AdultDbContext : DbContext
    {
        public DbSet<Adult> Adult { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Adult.db");
        }
    }
}