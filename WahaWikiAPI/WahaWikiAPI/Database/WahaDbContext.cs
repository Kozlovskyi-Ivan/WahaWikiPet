using Microsoft.EntityFrameworkCore;
using WahaWikiAPI.Entities;

namespace WahaWikiAPI.Database
{
    public class WahaDbContext : DbContext
    {
        public WahaDbContext(DbContextOptions<WahaDbContext> options) : base(options)
        {

        }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<UnitStat> StatLines { get; set; }
        public DbSet<Abilities> Abilities { get; set; }
        public DbSet<UnitWeaponRelationships> UnitWeaponRelationships { get; set; }
        public DbSet<UnitAbilitiesRelationships> UnitAbilitiesRelationships { get; set; }



        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<WeaponType> WeaponTypes { get; set; }
        public DbSet<WeaponAbilities> WeaponAbilities { get; set; }
        public DbSet<WeaponAbilitiesRelationships> WeaponAbilitiesRelationships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //WeaponAbilitiesRelationships
            modelBuilder.Entity<WeaponAbilitiesRelationships>()
                .HasKey(t => new { t.WeaponId, t.WeaponAbilitiesId });


            modelBuilder.Entity<Weapon>()
                .HasMany(x => x.WeaponAbilities)
                .WithMany(x => x.Weapons)
                .UsingEntity<WeaponAbilitiesRelationships>();

            //UnitAbilitiesRelationships
            modelBuilder.Entity<Unit>()
                .HasMany(x => x.Weapons)
                .WithMany(x => x.Units)
                .UsingEntity<UnitWeaponRelationships>();

            modelBuilder.Entity<Unit>()
                .HasMany(x => x.Abilities)
                .WithMany(x => x.Units)
                .UsingEntity<UnitAbilitiesRelationships>();

            modelBuilder.Entity<Unit>()
                .HasMany(x => x.UnitStatList)
                .WithOne(x => x.Unit);

        }



    }
}
