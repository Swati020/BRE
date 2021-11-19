using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing.Common;

namespace OrderProcessing.Rules.Tests
{
    [TestClass()]
    public class EmailRequiredRuleTests
    {
        [TestMethod()]
        public void ProcessingBizRulesFailTest()
        {
            Order order = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName" },
                ProductDetail = new Product { Catagories = ProductCatagories.Physical, Quantity = 2, UnitPrice = 50 },
                AgentDetail = new Agent { AgentId = 1 }
            };
            Assert.AreNotEqual(order.EmailRequired(), order.SendEmail());
        }
        [TestMethod()]
        public void ProcessingBizRulesSuccessTest()
        {
            Order order = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName" },
                ProductDetail = new Product { Catagories = ProductCatagories.Membership, Quantity = 2, UnitPrice = 50 },
                AgentDetail = new Agent { AgentId = 1 }
            };
            Assert.AreEqual(order.EmailRequired(), order.SendEmail());
        }
        [TestMethod()]
        public void ProcessingBizRulesSuccessOnUpgradeTest()
        {
            Order order = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName" },
                ProductDetail = new Product { Catagories = ProductCatagories.UpgradedMemberShip, Quantity = 2, UnitPrice = 50 },
                AgentDetail = new Agent { AgentId = 1 }
            };
            Assert.AreEqual(order.EmailRequired(), order.SendEmail());
        }
    }
}