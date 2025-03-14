using Microsoft.EntityFrameworkCore;
using SkiAPI.Models;
//this code is the translator that translates C# to databases
namespace SkiAPI.Repositories
{
    public class SkiDbContext : DbContext 
    {
        public SkiDbContext(DbContextOptions<SkiDbContext> options) : base(options) { } //call methods from dbcontext

        public DbSet<SkiBrand> SkiBrands { get; set; } //grabs everything from skibrands
    }
}