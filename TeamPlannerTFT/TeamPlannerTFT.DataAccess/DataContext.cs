using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamPlannerTFT.DataAccess.Model;

namespace TeamPlannerTFT.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Unit> Units { get; set; }
        public DbSet<Trait> Traits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = "Donau.hiof.no",
                InitialCatalog = "oskarlo",
                UserID = "oskarlo",
                Password = "l9Pk8xXKCY"
            };
            optionsBuilder.UseSqlServer(builder.ConnectionString.ToString());
        }

        //List<int> SyndicateNrForActivation = new List<int>() { 3, 5, 7 };
        //List<int> BodyguardeNrForActivation = new List<int>() { 2, 4, 6, 8 };

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trait>().HasData(new Trait(1, "Syndicate", "Certain allies are cloaked in shadows, gaining 50 Armor, 50 Magic Resist and 20% Omnivamp (healing for a percentage of all damage dealt.)"));
            modelBuilder.Entity<Trait>().HasData(new Trait(2, "Bodyguard", "Bodyguards have increased Armor. Shortly after combat begins, Bodyguards gain a shield and taunt adjacent enemies, forcing them to attack the Bodyguard."));

            modelBuilder.Entity<Unit>().HasData(new Unit(1, "Blitzcrank", 2, 0));
            modelBuilder.Entity<Unit>().HasData(new Unit(2, "Braum", 4, 0));
            modelBuilder.Entity<Unit>().HasData(new Unit(3, "Darius", 1, 0));
            modelBuilder.Entity<Unit>().HasData(new Unit(4, "Galio", 5, 0));
            modelBuilder.Entity<Unit>().HasData(new Unit(5, "Leona", 3, 0));
            modelBuilder.Entity<Unit>().HasData(new Unit(6, "Poppy", 1, 0));
            modelBuilder.Entity<Unit>().HasData(new Unit(7, "Ahri", 4, 0));
            modelBuilder.Entity<Unit>().HasData(new Unit(8, "Ashe", 2, 0));
            modelBuilder.Entity<Unit>().HasData(new Unit(9, "Morgana", 3, 0));
            modelBuilder.Entity<Unit>().HasData(new Unit(10, "Zyra", 2, 0));

            modelBuilder.Entity<Unit>()
                .HasMany(c => c.Traits)
                .WithMany(p => p.Units)
                .UsingEntity<Dictionary<string, object>>(
                    "UnitTrait",
                    r => r.HasOne<Trait>().WithMany().HasForeignKey("TraitsTraitId"),
                    l => l.HasOne<Unit>().WithMany().HasForeignKey("UnitsId"),
                    je =>
                    {
                        je.HasKey("UnitsId", "TraitsTraitId");
                        je.HasData(
                        #region Blitzcrank 
                            new { UnitsId = 1, TraitsTraitId = 2 },
                        #endregion
                        #region Braum
                            new { UnitsId = 2, TraitsTraitId = 1 },
                            new { UnitsId = 2, TraitsTraitId = 2 },
                        #endregion
                        #region Darius
                            new { UnitsId = 3, TraitsTraitId = 1 },
                            new { UnitsId = 3, TraitsTraitId = 2 },
                        #endregion
                        #region Galio
                            new { UnitsId = 4, TraitsTraitId = 2 },
                        #endregion
                        #region Leona
                            new { UnitsId = 5, TraitsTraitId = 2 },
                        #endregion
                        #region Poppy
                            new { UnitsId = 6, TraitsTraitId = 2 },
                        #endregion
                        #region Ahri
                            new { UnitsId = 7, TraitsTraitId = 1 },
                        #endregion
                        #region Ashe
                            new { UnitsId = 8, TraitsTraitId = 1 },
                        #endregion
                        #region Morgana
                            new { UnitsId = 9, TraitsTraitId = 1 },
                        #endregion
                        #region Zyra
                            new { UnitsId = 10, TraitsTraitId = 1 });
                        #endregion
                    });

        }

    }
}
