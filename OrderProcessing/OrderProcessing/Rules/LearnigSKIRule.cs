using OrderProcessing.Common;
using OrderProcessing.Interfaces;
using System;

namespace OrderProcessing.Rules
{
    public class LearnigSKIRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            var IsSuccess= order.IsLearningSkiVideo() && order.GenratePaymentSlip();
            return IsSuccess;
        }
    }
}
