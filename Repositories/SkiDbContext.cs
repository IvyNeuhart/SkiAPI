using Microsoft.EntityFrameworkCore;
using SkiAPI.Models;

namespace SkiAPI.Repositories
{
    public class SkiDbContext : DbContext
    {
        public SkiDbContext(DbContextOptions<SkiDbContext> options) : base(options) { }

        public DbSet<SkiBrand> SkiBrands { get; set; }
    }
}