using OrderProcessing.Common;
using OrderProcessing.Interfaces;
using System;
namespace OrderProcessing.Rules
{
    public class CommisionRule : IPostPaymentRule
    {
        readonly double StandardCommisionPercent = 2.5;// Assumed value
        public bool ProcessingBizRules(Order order)
        {
            bool result = false;
            if (order.IsCommisionRequired())
            {
                var totalSalesAmount = order.ProductDetail.Quantity * order.ProductDetail.UnitPrice;
                var commisionCalculated = (totalSalesAmount * StandardCommisionPercent) / 100;
                SendCommision(order.AgentDetail, commisionCalculated);
                result = true;
            }
            return result;
        }

        private void SendCommision(Agent agentDetail, double commisionAmount)
        {
            // call a payment plugin to sent the commision to respective agent using agent ID.
        }
    }
}
