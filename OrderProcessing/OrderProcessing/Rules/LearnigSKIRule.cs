using OrderProcessing.Common;
using OrderProcessing.Interfaces;
using System;

namespace OrderProcessing.Rules
{
    public class LearnigSKIRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
