using System;
using System.Collections.Generic;
using System.Text;
using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Facade.Quantity
{
    [TestClass]
    public class SystemOfUnitsViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(SystemOfUnitsViewFactory);
        }

        [TestMethod] public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<SystemOfUnitsView>();
            var data = SystemOfUnitsViewFactory.Create(view).Data;

            testArePropertyValuesEqual(view, data);

        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<SystemOfUnitsData>();
            var view = SystemOfUnitsViewFactory.Create(new SystemOfUnits(data));

            testArePropertyValuesEqual(view, data);

        }
    }
}
