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
            LearnigSKIRule learnigSKIRule = new LearnigSKIRule();
            Assert.AreNotEqual(order.IsLearningSkiVideo(), order.GenratePaymentSlip());
            Assert.IsFalse(learnigSKIRule.ProcessingBizRules(order));
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
            LearnigSKIRule learnigSKIRule = new LearnigSKIRule();
            Assert.AreEqual(order.IsLearningSkiVideo(), order.GenratePaymentSlip());
            Assert.IsTrue(learnigSKIRule.ProcessingBizRules(order));
        }
    }
}