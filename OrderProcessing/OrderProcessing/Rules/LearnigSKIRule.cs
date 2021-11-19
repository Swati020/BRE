using OrderProcessing.Common;
using OrderProcessing.Interfaces;

namespace OrderProcessing.Rules
{
    /// <summary>
    /// LearnigSKIRule is the check if video is Learning SKI video or not then go ahead to genrate payment slip with first aid video. 
    /// GenratePaymentSlip method is self sufficient to handle use case of Learning SKI
    /// </summary>
    public class LearnigSKIRule : IPostPaymentRule
    {
        public bool ProcessingBizRules(Order order)
        {
            var IsSuccess = order.IsLearningSkiVideo() && order.GenratePaymentSlip();
            return IsSuccess;
        }
    }
}
