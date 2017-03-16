using Backend.Models;
using Microsoft.EntityFrameworkCore;



namespace Backend.Data
{
    public class Phase4Context : DbContext
    {
        public Phase4Context(DbContextOptions<Phase4Context> options) : base(options)
        {
        }

        public DbSet<Airport> Airports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airport>().ToTable("Airport");
        }
    }
}
