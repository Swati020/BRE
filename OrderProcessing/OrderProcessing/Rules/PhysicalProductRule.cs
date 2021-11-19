using OrderProcessing.Common;
using OrderProcessing.Interfaces;

namespace OrderProcessing.Rules
{
    public class PhysicalProductRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            return order.IsPhysical() && order.GenratePaymentSlip();
        }
    }
}
