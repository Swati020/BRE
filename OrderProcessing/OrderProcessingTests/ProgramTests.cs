using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderProcessing.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            try
            {
                Program program = new Program();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}