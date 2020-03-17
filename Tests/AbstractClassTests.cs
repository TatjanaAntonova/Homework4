using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests
{
    public abstract class AbstractClassTests<TClass, TBaseClass>: BaseClassTests<TClass, TBaseClass>
    {
        [TestMethod]
        public void IsAbstract()
        {
            Assert.IsTrue(type.IsAbstract);
        }
    }
}