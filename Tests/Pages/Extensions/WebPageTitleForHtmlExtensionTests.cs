using Homework4.Pages.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework4.Tests.Pages.Extensions
{
    [TestClass]
    public class WebPageTitleForHtmlExtensionTests : BaseTests
    {
        [TestInitialize] public virtual void TestInitialize() => type = typeof(WebPageTitleForHtmlExtension);

        [TestMethod]
        public void WebPageTitleForTest()
        {
            Assert.Inconclusive();
        }
    }
}