using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests
{
    public abstract class AbstractClassTest<TClass, TBaseClass>: BaseTest<TClass, TBaseClass>
    {
        [TestMethod]
        public void IsAbstract()
        {
            Assert.IsTrue(type.IsAbstract);
        }
    }
}