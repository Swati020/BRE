using OrderProcessing.Common;
using OrderProcessing.Interfaces;

namespace OrderProcessing.Rules
{
    /// <summary>
    /// PhysicalProductRule class is use to validate category is physical if yes then process to generate payment slip 
    /// </summary>
    public class PhysicalProductRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            return order.IsPhysical() && order.GenratePaymentSlip();
        }
    }
}
