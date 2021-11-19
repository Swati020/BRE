using OrderProcessing.Common;
using OrderProcessing.Interfaces;
namespace OrderProcessing.Rules
{
    /// <summary>
    /// BookProductRule class is use to check state of valid product category as book then to process the payment slip generation.
    /// </summary>
    public class BookProductRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            return order.IsBook() && order.GenratePaymentSlip(true);
        }
    }
}
