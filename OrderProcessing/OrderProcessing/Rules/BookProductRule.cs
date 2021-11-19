using OrderProcessing.Common;
using OrderProcessing.Interfaces;
namespace OrderProcessing.Rules
{
    public class BookProductRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            return order.IsBook() && order.GenratePaymentSlip(true);
        }
    }
}
