using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests
{
    public abstract class ClassTest<TClass, TBaseClass>: BaseTest<TClass, TBaseClass> where TClass : new()
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            obj = new TClass();
            type = obj.GetType();
        }

        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(obj);
        }
    }
}