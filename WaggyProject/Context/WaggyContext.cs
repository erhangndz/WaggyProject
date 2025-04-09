using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WaggyProject.Entities;

namespace WaggyProject.Context
{
    public class WaggyContext: IdentityDbContext<AppUser,AppRole,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ERHAN\\SQLEXPRESS;database=WaggyDb;integrated security=true; trustServerCertificate=true");
        }


        //pluralize  
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
