using System;
using System.Threading.Tasks;
using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Infra;
using Homework4.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Infra
{
    [TestClass]
    public class SortedRepositoryTests: AbstractClassTest<SortedRepository<Measure, MeasureData>, BaseRepository<Measure, MeasureData>>
    {
        private class testClass : SortedRepository<Measure, MeasureData>
        {
            public testClass(DbContext c, DbSet<MeasureData> s) : base(c, s)
            {
            }

            protected override Task<MeasureData> getData(string id)
            {
                throw new NotImplementedException();
            }
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var c = new QuantityDbContext(new DbContextOptions<QuantityDbContext>());
            obj = new testClass(c, c.Measures);
        }

        [TestMethod]
        public void SortOrderTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void DescendingStringTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SetSortingTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void CreateExpressionTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void LambdaExpressionTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void FindProperty()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetName()
        {
            Assert.Inconclusive();
        }
        
        [TestMethod]
        public void SetOrderBy()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void IsDescendingTest()
        {
            obj.SortOrder = GetRandom.String();
            Assert.IsFalse(obj.isDescending());
            obj.SortOrder += obj.DescendingString;
            Assert.IsTrue(obj.isDescending());
        }
    }
}
