using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MainApp.Test
{
    [TestClass]
    public class BasicTest
    {
        [TestMethod]
        public void AreEqual()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void AreNotEqual()
        {
            Assert.AreNotEqual(1, 2);
        }
    }
}
