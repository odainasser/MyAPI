using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Weather> Weather { get; set; }
    }
}