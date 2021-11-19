using OrderProcessing.Common;
using OrderProcessing.Interfaces;

namespace OrderProcessing.Rules
{
    /// <summary>
    /// MembershipProductRule to Activate Membership of customer.
    /// </summary>
    public class MembershipProductRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            bool result = false;
            if (order.IsMember())
            {
                order.CustomerDetail.Active = true;
                result = true;
            }
            return result;
        }
    }
}
