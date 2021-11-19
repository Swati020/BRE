using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing.Common;

namespace OrderProcessing.Rules.Tests
{
    [TestClass()]
    public class BookProductRuleTests
    {
        [TestMethod()]
        public void ProcessingBizRulesTest()
        {
            Order order = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName" },
                ProductDetail = new Product { Catagories = ProductCatagories.Books, Quantity = 12, UnitPrice = 50 },
                AgentDetail = new Agent { AgentId = 1 }
            };
            BookProductRule bookProduct = new BookProductRule();
            Assert.IsTrue(bookProduct.ProcessingBizRules(order));
        }
        [TestMethod()]
        public void ProcessingBizRulesFailedTest()
        {
            Order order = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName" },
                ProductDetail = new Product { Catagories = ProductCatagories.SkiLearningvideos, Quantity = 1, UnitPrice = 150 },
                AgentDetail = new Agent { AgentId = 1 }
            };
            BookProductRule bookProduct = new BookProductRule();
            Assert.IsFalse(bookProduct.ProcessingBizRules(order));
        }
    }
}