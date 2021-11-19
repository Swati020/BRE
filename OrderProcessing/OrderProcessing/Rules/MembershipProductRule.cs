using OrderProcessing.Common;
using OrderProcessing.Interfaces;
using System;

namespace OrderProcessing.Rules
{
    public class MembershipProductRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            bool result = false;
            if (order.IsMember())
            {
                order.CustomerDetail.Active = true;
                result = true;
            }
            return result;
        }
    }
}
