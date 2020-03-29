using Homework4.Data.Common;
using Homework4.Data.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Data.Quantity
{
    [TestClass]
    public class CommonTermDataTests: AbstractClassTests<CommonTermData, PeriodData>
    {
        private class testClass : CommonTermData { }

        [TestInitialize]

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

        [TestMethod]
        public void TermIdTest()
        {
            isNullableProperty(() => obj.TermId, x => obj.TermId = x);
        }

        [TestMethod]
        public void PowerTest()
        {
            isProperty(() => obj.Power, x => obj.Power = x);
        }
    }
}
