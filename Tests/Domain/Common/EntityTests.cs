﻿using Homework4.Aids;
using Homework4.Data.Quantity;
using Homework4.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Domain.Common
{
    [TestClass]
    public class EntityTests: AbstractClassTests<Entity<MeasureData>, object>
    {
        private class testClass : Entity<MeasureData>
        {
            public testClass(MeasureData d = null) : base(d) { }
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void DataTest()
        {
            var d = GetRandom.Object<MeasureData>();
            Assert.AreNotSame(d, obj.Data);
            obj = new testClass(d);
            Assert.AreSame(d, obj.Data);
        }

        [TestMethod]
        public void DataIsNullTest()
        {
            var d = GetRandom.Object<MeasureData>();
            Assert.IsNotNull(obj.Data);
            obj.Data = d;
            Assert.AreSame(d, obj.Data);
        }

        [TestMethod]
        public void CanSetDataNullTest()
        {
            Assert.IsNotNull(obj.Data);
            obj.Data = null;
            Assert.IsNull(obj.Data);
        }
    }
}