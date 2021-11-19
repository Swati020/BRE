using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing.Common;

namespace OrderProcessing.Rules.Tests
{
    [TestClass()]
    public class LearnigSKIRuleTests
    {
        [TestMethod()]
        public void ProcessingBizRulesFailTest()
        {
            Order order = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName" },
                ProductDetail = new Product { Catagories = ProductCatagories.Physical, Quantity = 12, UnitPrice = 50 },
                AgentDetail = new Agent { AgentId = 1 }
            };
            Assert.AreNotEqual(order.IsLearningSkiVideo(), order.GenratePaymentSlip());
        }
        [TestMethod()]
        public void ProcessingBizRulesSuccessTest()
        {
            Order order = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName" },
                ProductDetail = new Product { Catagories = ProductCatagories.SkiLearningvideos, Quantity = 1, UnitPrice = 20 },
                AgentDetail = new Agent { AgentId = 1 }
            };
            Assert.AreEqual(order.IsLearningSkiVideo(), order.GenratePaymentSlip());
        }
    }
}