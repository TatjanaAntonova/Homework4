﻿using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Facade.Quantity
{
    [TestClass]
    public class MeasureTermViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(MeasureTermViewFactory);
        }

        [TestMethod] public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<MeasureTermView>();
            var data = MeasureTermViewFactory.Create(view).Data;

            testArePropertyValuesEqual(view, data);

        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<MeasureTermData>();
            var view = MeasureTermViewFactory.Create(new MeasureTerm(data));

            testArePropertyValuesEqual(view, data);

        }
    }
}
