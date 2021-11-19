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
            List<Order> processedOrderList = new List<Order>();
            Order order1 = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName" },
                ProductDetail = new Product { Catagories = ProductCatagories.Physical, Quantity = 2, UnitPrice = 50 },
                AgentDetail = new Agent { AgentId = 1 }
            };
            Order order2 = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName" },
                ProductDetail = new Product { Catagories = ProductCatagories.Books, Quantity = 2, UnitPrice = 50 },
                AgentDetail = new Agent { AgentId = 1 }
            };
            Order order3 = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName" },
                ProductDetail = new Product { Catagories = ProductCatagories.Membership, Quantity = 2, UnitPrice = 50 },
                AgentDetail = new Agent { AgentId = 1 }
            };
            Order order4 = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName", Active=true, Upgraded=false },
                ProductDetail = new Product { Catagories = ProductCatagories.UpgradedMemberShip, Quantity = 2, UnitPrice = 50 },
                AgentDetail = new Agent { AgentId = 1 }
            };
            processedOrderList.Add(order1);
            processedOrderList.Add(order2);
            processedOrderList.Add(order3);
            processedOrderList.Add(order4);
            PostPayment postPayment = new PostPayment();
            foreach (var order in processedOrderList)
            {
                Assert.IsTrue(postPayment.PostPaymentProcessing(order));
            }
        }
        [TestMethod()]
        public void PostPaymentProcessinNullReferenceExceptionTest()
        {
            PostPayment postPayment = new PostPayment();
            Assert.ThrowsException<System.NullReferenceException>(() => postPayment.PostPaymentProcessing(null));
        }
    }
}