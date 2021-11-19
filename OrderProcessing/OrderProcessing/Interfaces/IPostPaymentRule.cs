using OrderProcessing.Common;

namespace OrderProcessing.Interfaces
{
    public interface IPostPaymentRule
    {
        bool ProcessingBizRules(Order order);
    }
}
