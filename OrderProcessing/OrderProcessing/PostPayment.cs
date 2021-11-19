using OrderProcessing.Common;
using OrderProcessing.Interfaces;
using OrderProcessing.Rules;
using System.Collections.Generic;

namespace OrderProcessing
{
    public class PostPayment : IPostPayment
    {
        List<IPostPaymentRule> _rules = new List<IPostPaymentRule>();
        public PostPayment()
        {
            _rules.Add(new PhysicalProductRule());
        }
        public bool PostPaymentProcessing(Order order)
        {
            return _rules[0].ProcessingBizRules(order);
        }
    }
}
