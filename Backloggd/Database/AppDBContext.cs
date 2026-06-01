using Backloggd.Models;
using Microsoft.EntityFrameworkCore;

namespace Backloggd.Database
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options){}

        //Definiere die Models die EF-Core verwenden soll
        
        public DbSet<Spiel>Spiel { get; set; }

        public DbSet<Review> Review { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // SEHR WICHTIG: Hier das zugewiesene Schema eintragen
            modelBuilder.HasDefaultSchema("HauserKarlHeinz_3CK");//heidi ordnername

            

            base.OnModelCreating(modelBuilder);
        }
    }
}
