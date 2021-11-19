using OrderProcessing.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Interfaces
{
    public interface IPostPaymentRule
    {
        bool ProcessingBizRules(Order order);
    }
}
