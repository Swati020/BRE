using OrderProcessing.Common;
using OrderProcessing.Interfaces;
using System;
namespace OrderProcessing.Rules
{
    public class BookProductRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
