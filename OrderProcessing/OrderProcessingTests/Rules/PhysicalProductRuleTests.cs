using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing.Common;

namespace OrderProcessing.Rules.Tests
{
    [TestClass()]
    public class PhysicalProductRuleTests
    {
        [TestMethod()]
        public void ProcessingBizRulesTest()
        {
            Order order = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName" },
                ProductDetail = new Product { Catagories = ProductCatagories.Physical, Quantity = 1, UnitPrice = 50 },
                AgentDetail = new Agent { AgentId = 1 }
            };
            PhysicalProductRule physicalProduct = new PhysicalProductRule();
            Assert.IsTrue(physicalProduct.ProcessingBizRules(order));
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
            PhysicalProductRule physicalProduct = new PhysicalProductRule();
            Assert.IsFalse(physicalProduct.ProcessingBizRules(order));
        }
    }
}