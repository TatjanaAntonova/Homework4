using Homework4.Data.Common;
using Homework4.Data.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Data.Quantity
{
    [TestClass]
    public class UnitDataTests: SealedClassTests<UnitData, DefinedEntityData>
    {
        [TestMethod]
        public void MeasureIdTest()
        {
            isNullableProperty(() => obj.MeasureId, x => obj.MeasureId = x);
        }
    }
}
