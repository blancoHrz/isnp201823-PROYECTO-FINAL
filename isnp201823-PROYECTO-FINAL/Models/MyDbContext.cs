using Microsoft.EntityFrameworkCore;
namespace isnp201823_PROYECTO_FINAL.Models {
    public class MyDbContext : DbContext{ 
        public MyDbContext (){}

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}
        public DbSet<Peliculas> Peliculas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Peliculas>().HasKey (peliculas => peliculas.IdPeliculas);

        }

    }
    
 }

