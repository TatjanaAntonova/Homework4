using System;
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
        [TestInitialize] public override void TestInitialize()
        {
            base.TestInitialize();
            var options = new DbContextOptionsBuilder<QuantityDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            var c = new QuantityDbContext(options);
            obj = new MeasuresRepository(c);
        }
        protected override Type getBaseType()
        {
            return typeof(UniqueEntityRepository<Measure, MeasureData>);
        }

        protected override void testGetList()
        {
            Assert.Inconclusive();
        }

        protected override string getId(MeasureData d) => d.Id;
        
        protected override Measure getObject(MeasureData d) => new Measure(d);

        protected override void setId(MeasureData d, string id) => d.Id = id;
    }
}
