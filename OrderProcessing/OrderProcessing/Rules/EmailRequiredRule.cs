using OrderProcessing.Common;
using OrderProcessing.Interfaces;
namespace OrderProcessing.Rules
{
    public class EmailRequiredRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            bool isSuccess = order.EmailRequired() && order.SendEmail();
            return isSuccess;
        }
    }
}
