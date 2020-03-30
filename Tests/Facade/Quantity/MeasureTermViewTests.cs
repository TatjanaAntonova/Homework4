using Homework4.Facade.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Facade.Quantity
{
    [TestClass]
    public class MeasureTermViewTests : SealedClassTests<MeasureTermView, CommonTermView>
    {
        [TestMethod]
        public void MasterIdTest() => isNullableProperty(() => obj.MasterId, x => obj.MasterId = x);
    }
}
