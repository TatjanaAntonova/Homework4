using System;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Infra;
using Homework4.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Infra.Quantity
{
    [TestClass]
    public class UnitsRepositoryTests: RepositoryTests<UnitsRepository, Unit, UnitData>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            var options = new DbContextOptionsBuilder<QuantityDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            db = new QuantityDbContext(options);
            dbSet = ((QuantityDbContext)db).Units;
            obj = new UnitsRepository((QuantityDbContext)db);

            base.TestInitialize();
        }
        protected override Type getBaseType() => typeof(UniqueEntityRepository<Unit, UnitData>);

        protected override string getId(UnitData d) => d.Id;

        protected override Unit getObject(UnitData d) => new Unit(d);

        protected override void setId(UnitData d, string id) => d.Id = id;
    }
}
