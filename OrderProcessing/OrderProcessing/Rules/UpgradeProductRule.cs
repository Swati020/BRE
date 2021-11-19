using OrderProcessing.Common;
using OrderProcessing.Interfaces;
using System;

namespace OrderProcessing.Rules
{
    public class UpgradeProductRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            bool result = false;
            if (order.IsUpgraded())
            {
                order.CustomerDetail.Upgraded = true;
                result = true;
            }
            return result;
        }
    }
}
