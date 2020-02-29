using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;

namespace Homework4.Infra.Quantity
{
    public class QuantityDbContext: DbContext
    {
        public DbSet<MeasureData> Measures { get; set; }
        public DbSet<UnitData> Units { get; set; }
        public DbSet<SystemOfUnitsData> SystemsOfUnits { get; set; }
        public DbSet<UnitFactorData> UnitFactors { get; set; }

        public QuantityDbContext(DbContextOptions<QuantityDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }

        public static void InitializeTables(ModelBuilder builder)
        {
            builder.Entity<MeasureData>().ToTable(nameof(Measures));
            builder.Entity<UnitData>().ToTable(nameof(Units));
            builder.Entity<SystemOfUnitsData>().ToTable(nameof(SystemsOfUnits));
            builder.Entity<UnitFactorData>().ToTable(nameof(UnitFactors)).HasKey(x=> new {x.UnitId, x.SystemOfUnitsId});
        }
    }
}
