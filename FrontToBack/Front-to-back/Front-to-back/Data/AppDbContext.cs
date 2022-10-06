using Front_to_back.Models;
using Microsoft.EntityFrameworkCore;

namespace Front_to_back.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<Work> Works { get; set; }
    }
}
