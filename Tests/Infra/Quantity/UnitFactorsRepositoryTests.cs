﻿using System;
using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Infra;
using Homework4.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Infra.Quantity
{
    [TestClass]
    public class UnitFactorsRepositoryTests : RepositoryTests<UnitFactorsRepository, UnitFactor, UnitFactorData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<QuantityDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new QuantityDbContext(options);
            dbSet = ((QuantityDbContext)db).UnitFactors;
            obj = new UnitFactorsRepository((QuantityDbContext)db);
            base.TestInitialize();
        }


        protected override Type getBaseType()
        {
            return typeof(PaginatedRepository<UnitFactor, UnitFactorData>);
        }

        protected override string getId(UnitFactorData d) => $"{d.SystemOfUnitsId}.{d.UnitId}";

        protected override UnitFactor getObject(UnitFactorData d) => new UnitFactor(d);

        protected override void setId(UnitFactorData d, string id)
        {
            var systemOfUnitsId = GetString.Head(id);
            var unitId = GetString.Tail(id);
            d.SystemOfUnitsId = systemOfUnitsId;
            d.UnitId = unitId;
        }
    }
}


