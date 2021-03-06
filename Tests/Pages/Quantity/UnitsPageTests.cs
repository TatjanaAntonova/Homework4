﻿using System.Linq;
using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;
using Homework4.Pages;
using Homework4.Pages.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Pages.Quantity
{
    [TestClass]
    public class UnitsPageTests : AbstractClassTests<UnitsPage, 
        CommonPage<IUnitsRepository, Unit, UnitView, UnitData>>
    {
        private class testClass : UnitsPage
        {
            internal testClass(IUnitsRepository r, IMeasuresRepository m) : base(r, m, null, null) { }
        }

        private class unitsRepository : baseTestRepositoryForUniqueEntity<Unit, UnitData>, IUnitsRepository { }
        private class measuresRepository : baseTestRepositoryForUniqueEntity<Measure, MeasureData>, IMeasuresRepository { }

        private unitsRepository units;
        private measuresRepository measures;
        private MeasureData data;

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            units = new unitsRepository();
            measures = new measuresRepository();
            data = GetRandom.Object<MeasureData>();
            var m = new Measure(data);
            measures.Add(m).GetAwaiter();
            addRandomMeasures();
            obj = new testClass(units, measures);
        }

        private void addRandomMeasures()
        {
            for (var i = 0; i < GetRandom.UInt8(3, 10); i++)
            {
                var d = GetRandom.Object<MeasureData>();
                var m = new Measure(data);
                measures.Add(m).GetAwaiter();
            }
        }

        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<UnitView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }
        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Units", obj.PageTitle);

        [TestMethod]
        public void PageUrlTest() => Assert.AreEqual("/Quantity/Units", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<UnitView>();
            var o = obj.toObject(view);
            testArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var d = GetRandom.Object<UnitData>();
            var view = obj.toView(new Unit(d));
            testArePropertyValuesEqual(view, d);
        }

        [TestMethod]
        public void GetMeasureNameTest()
        {
            
            var name = obj.GetMeasureName(data.Id);
            Assert.AreEqual(data.Name, name);
        }
        [TestMethod]
        public void MeasuresTest()
        {
            var list = measures.Get().GetAwaiter().GetResult();
            Assert.AreEqual(list.Count, obj.Measures.Count());
        }
    }
}

