using OrderProcessing.Common;
using OrderProcessing.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
namespace OrderProcessing.Rules
{
    public class CommisionRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            throw new NotImplementedException();
        }
     }
}
