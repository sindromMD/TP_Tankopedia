using Microsoft.EntityFrameworkCore;
using TP_Tankopedia_ASP.Models;

namespace TP_Tankopedia_ASP.Data
{
    public class TankopediaDbContext : DbContext
    {
        public TankopediaDbContext(DbContextOptions<TankopediaDbContext> options)
            : base(options) { }

        public DbSet<Nation> Nations { get; set; }
        public DbSet<Tank>? Tanks { get; set; }
        public DbSet<TypeTank> TypeTanks { get; set; }
        public DbSet<StrategicRole> StrategicRoles { get; set; }
        public DbSet<TankModule> TankModules { get; set; }
        public DbSet<Characteristics> Characteristics { get; set; }

        //parcourir toutes les entités et leurs propriétés pour trouver toutes les propriétés décimales et les définir (6,2)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(decimal))
                    {
                        property.SetColumnType("decimal(6, 2)");
                    }
                }
            }
        }
    }
}