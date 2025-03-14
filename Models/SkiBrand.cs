using Microsoft.EntityFrameworkCore;
using SkiAPI.Models;

namespace SkiAPI.Models
{
    public class SkiBrand
    {
        public int Id { get; set; } //each table is going to have a unique identifier
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? DateFounded { get; set; }

        // Navigation property to represent one (brand) to many (skis) relationship.
        public List<SkiBrand> SkiBrands { get; set; }
        public DbSet<SkiModel> SkiModels { get; set; }
    }
}