using Homework4.Data.Common;
using Homework4.Data.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Data.Quantity
{
    [TestClass]
    public class CommonTermTests: AbstractClassTests<CommonTermData, PeriodData>
    {
        private class testClass : CommonTermData
        {
        }

        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void MasterIdTest()
        {
            isNullableProperty(()=>obj.MasterId, x=> obj.MasterId=x);
        }
    }
}
