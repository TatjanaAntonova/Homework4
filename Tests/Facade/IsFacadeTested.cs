﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Facade
{
    [TestClass]
    public class IsFacadeTested: AssemblyTests
    {
        private const string assembly = "Homework4.Facade";

        protected override string Namespace(string name) { return $"{assembly}.{name}"; }
        [TestMethod]
        public void IsCommonTested() { isAllTested(assembly, Namespace("Common")); }

        [TestMethod]
        public void IsQuantityTested() { isAllTested(assembly, Namespace("Quantity")); }

        [TestMethod]
        public void IsTested() { isAllTested(base.Namespace("Facade")); }
    }
}
