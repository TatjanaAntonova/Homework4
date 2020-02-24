﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;

namespace Homework4.Infra.Quantity
{
    public class QuantityDbContext: DbContext
    {
        public QuantityDbContext(DbContextOptions<QuantityDbContext> options)
            : base(options)
        {
        }
        public DbSet<MeasureData> Measures { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }

        public static void InitializeTables(ModelBuilder builder)
        {
            builder.Entity<MeasureData>().ToTable(nameof(Measures));
        }
    }
}
