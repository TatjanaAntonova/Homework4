﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Pages
{
    [TestClass]
    public class IsPagesTested : AssemblyTests
    {
        private const string assembly = "Homework4.Pages";

        protected override string Namespace(string name) { return $"{assembly}.{name}"; }
        [TestMethod]
        public void IsExtensionsTested() { isAllTested(assembly, Namespace("Extensions")); }

        [TestMethod]
        public void IsQuantityTested() { isAllTested(assembly, Namespace("Quantity")); }

        [TestMethod]
        public void IsTested() { isAllTested(assembly, base.Namespace("Pages")); }
    }
}

   