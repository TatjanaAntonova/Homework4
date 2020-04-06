﻿using System;
using System.Collections.Generic;
using System.Text;
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
    public class MeasuresRepositoryTests: RepositoryTests<MeasuresRepository, Measure, MeasureData>
    {
        private QuantityDbContext db;
        private int count;
        [TestInitialize] public override void TestInitialize()
        {
            base.TestInitialize();
            var options = new DbContextOptionsBuilder<QuantityDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new QuantityDbContext(options);
            obj = new MeasuresRepository(db);
            foreach (var p in db.Measures)
                db.Entry(p).State = EntityState.Deleted;
            count = GetRandom.UInt8(20, 40);
            addItems();

        }
        private void addItems()
        {
            for (var i = 0; i < count; i++)
                obj.Add(new Measure(GetRandom.Object<MeasureData>())).GetAwaiter();
        }
        protected override Type getBaseType()
        {
            return typeof(UniqueEntityRepository<Measure, MeasureData>);
        }

        protected override void testGetList()
        {
            obj.PageIndex = GetRandom.Int32(2, obj.TotalPages -1);
            var l = obj.Get().GetAwaiter().GetResult();
            Assert.AreEqual(obj.PageSize, l.Count);
        }

        protected override string getId(MeasureData d) => d.Id;
        
        protected override Measure getObject(MeasureData d) => new Measure(d);

        protected override void setId(MeasureData d, string id) => d.Id = id;
    }
}
