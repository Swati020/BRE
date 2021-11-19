using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing.Common;
using System.Collections.Generic;

namespace OrderProcessing.Tests
{
    [TestClass()]
    public class PostPaymentTests
    {
        [TestMethod()]
        public void PostPaymentProcessingTest()
        {
            Order order = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName" },
                ProductDetail = new Product { Catagories = ProductCatagories.Physical, Quantity = 2, UnitPrice = 50 },
                AgentDetail = new Agent { AgentId = 1 }
            };

            PostPayment postPayment = new PostPayment();
            Assert.IsTrue(postPayment.PostPaymentProcessing(order));

        }
        [TestMethod()]
        public void PostPaymentProcessinNullReferenceExceptionTest()
        {
            PostPayment postPayment = new PostPayment();
            Assert.ThrowsException<System.NullReferenceException>(() => postPayment.PostPaymentProcessing(null));
        }
    }
}