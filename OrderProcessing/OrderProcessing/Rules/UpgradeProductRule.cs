using OrderProcessing.Common;
using OrderProcessing.Interfaces;

namespace OrderProcessing.Rules
{
    /// <summary>
    /// UpgradeProductRule to validate the upgrade rule and the update Customer Detail
    /// </summary>
    public class UpgradeProductRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            bool result = false;
            if (order.IsUpgraded())
            {
                order.CustomerDetail.Upgraded = true;
                result = true;
            }
            return result;
        }
    }
}
