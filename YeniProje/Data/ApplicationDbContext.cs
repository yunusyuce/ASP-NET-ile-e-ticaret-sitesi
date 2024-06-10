using Microsoft.EntityFrameworkCore;
using YeniProje.Models;

namespace YeniProje.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options) 
        {
        }

        public DbSet<Category>? Categories { get; set; } 
        
        public DbSet<Products>? Products { get; set; }   

        public DbSet<Slider>? Sliders { get; set; }  
    }
}
