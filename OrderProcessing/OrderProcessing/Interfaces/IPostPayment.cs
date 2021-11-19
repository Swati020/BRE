using OrderProcessing.Common;

namespace OrderProcessing.Interfaces
{
    public interface IPostPayment
    {
        public bool PostPaymentProcessing(Order order);
    }
}
