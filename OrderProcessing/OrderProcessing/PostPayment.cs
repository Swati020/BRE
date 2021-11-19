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
            _rules.Add(new BookProductRule());
            _rules.Add(new MembershipProductRule());
            _rules.Add(new UpgradeProductRule());      

        }
        public bool PostPaymentProcessing(Order order)
        {
            bool isProcessCompleted = false;
            foreach (var rule in _rules)
            {
                var result = rule.ProcessingBizRules(order);
                if (result)
                    isProcessCompleted = result;
            }
            return isProcessCompleted;
        }
    }
}
