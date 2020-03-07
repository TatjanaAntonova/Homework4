using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests
{
    public abstract class SealedClassTest<TClass, TBaseClass>: ClassTest<TClass, TBaseClass> where TClass : new()
    {
        [TestMethod]
        public void IsSealed()
        {
            Assert.IsTrue(type.IsSealed);
        }
    }
}