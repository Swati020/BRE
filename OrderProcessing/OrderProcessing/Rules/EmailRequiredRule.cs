using OrderProcessing.Common;
using OrderProcessing.Interfaces;
namespace OrderProcessing.Rules
{
    /// <summary>
    /// EmailRequiredRule class validate the email needs to be send if yest then call sendmail process
    /// </summary>
    public class EmailRequiredRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            bool isSuccess = order.EmailRequired() && order.SendEmail();
            return isSuccess;
        }
    }
}
