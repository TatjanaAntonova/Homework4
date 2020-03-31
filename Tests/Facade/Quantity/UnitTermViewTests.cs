using System;
using System.Collections.Generic;
using System.Text;
using Homework4.Facade.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Facade.Quantity
{
    [TestClass]
    public class UnitTermViewTests : SealedClassTests<UnitTermView, CommonTermView>
    {
        [TestMethod] public void MasterIdTest() => isNullableProperty(() => obj.MasterId, x => obj.MasterId = x);
    }
    
}
