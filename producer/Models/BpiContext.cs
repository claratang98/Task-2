using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using producer.Models;
using producer.Controllers;

namespace producer.Models
{
    public class BpiContext : DbContext
    {
        public BpiContext(DbContextOptions<BpiContext> options)
            : base(options)
        {
        }

        public DbSet<BpiItem> BpiItems { get; set; } = null!;
    }
}
