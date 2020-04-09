﻿using System;
using Homework4.Facade.Common;
using Homework4.Facade.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Facade.Quantity
{
    [TestClass]
    public class UnitFactorViewTests: SealedClassTests<UnitFactorView, PeriodView>
    {
        [TestMethod] public void UnitIdTest() => isNullableProperty(() => obj.UnitId, x => obj.UnitId = x);
        [TestMethod] public void SystemOfUnitsIdTest() => isNullableProperty(() => obj.SystemOfUnitsId, x => obj.SystemOfUnitsId = x);
        [TestMethod] public void FactorTest() => isProperty(() => obj.Factor, x => obj.Factor = x);
        [TestMethod]
        public void GetIdTest()
        {
            var actual = obj.GetId();
            var expected = $"{obj.SystemOfUnitsId}.{obj.UnitId}";
            Assert.AreEqual(expected, actual);
        }
    }
}
