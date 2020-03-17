using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Data
{
    [TestClass]
    public class IsDataTested: AssemblyTests
    {
        private const string assembly = "Homework4.Data";

        protected override string Namespace(string name) { return $"{assembly}.{name}"; }
        [TestMethod]
        public void IsCommonTested() { isAllTested(assembly, Namespace("Common"));}

        [TestMethod]
        public void IsMoneyTested() { isAllTested(assembly, Namespace("Money")); }

        [TestMethod]
        public void IsQuantityTested() { isAllTested(assembly, Namespace("Quantity")); }
        
        [TestMethod]
        public void IsTested() { isAllTested(assembly,base.Namespace("Data")); }
    }
}
