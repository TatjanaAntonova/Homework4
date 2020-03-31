using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Quantity;
using Homework4.Facade.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Facade.Quantity
{
    [TestClass]
    public class UnitFactorViewFactoryTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(UnitFactorViewFactory);
        }

        [TestMethod] public void CreateTest() { }

        [TestMethod]
        public void CreateObjectTest()
        {
            var view = GetRandom.Object<UnitFactorView>();
            var data = UnitFactorViewFactory.Create(view).Data;

            testArePropertyValuesEqual(view, data);

        }

        [TestMethod]
        public void CreateViewTest()
        {
            var data = GetRandom.Object<UnitFactorData>();
            var view = UnitFactorViewFactory.Create(new UnitFactor(data));

            testArePropertyValuesEqual(view, data);

        }
    }
}