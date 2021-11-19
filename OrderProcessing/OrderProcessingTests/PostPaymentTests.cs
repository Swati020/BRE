using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrderProcessing.Tests
{
    [TestClass()]
    public class PostPaymentTests
    {
        [TestMethod()]
        public void PostPaymentProcessinNotImplementedExceptionTest()
        {
            PostPayment postPayment = new PostPayment();
            Assert.ThrowsException<System.NotImplementedException>(() => postPayment.PostPaymentProcessing(null));
        }
    }
}