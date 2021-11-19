namespace OrderProcessing.Common
{
    public static class OrderExtensions
    {
        public static bool IsPhysical(this Order order)
        {
            return order.ProductDetail.Catagories == ProductCatagories.Physical;
        }
        public static bool IsBook(this Order order)
        {
            return order.ProductDetail.Catagories == ProductCatagories.Books;
        }
        public static bool IsMember(this Order order)
        {
            return order.ProductDetail.Catagories == ProductCatagories.Membership;
        }
        public static bool IsUpgraded(this Order order)
        {
            return order.ProductDetail.Catagories == ProductCatagories.UpgradedMemberShip;
        }
        public static bool EmailRequired(this Order order)
        {
            if (order.IsMember() || order.IsUpgraded())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool IsLearningSkiVideo(this Order order)
        {
            return order.ProductDetail.Catagories == ProductCatagories.SkiLearningvideos;
        }
        #region Processing Methods
        /// <summary>
        /// GenratePaymentSlip
        /// </summary>
        /// <param name="order">Order object caontains full information that will be required payment Slip</param>
        /// <param name="isDuplicate">Optional parameter to be enable true when a duplicate payment slip needs to be generated</param>
        /// <returns></returns>
        public static bool GenratePaymentSlip(this Order order, bool isDuplicate = false)
        {
            bool result;
            if (isDuplicate)
            {
                //TODO Implement Code to genrate Payment Slip in form of PDF with Duplicate watermark for royality department.
                result = true;
            }
            else
            {
                //TODO Implement Code to genrate Orignal Payment Slip in form of PDF.
                result = true;
            }
            return result;
        }
        /// <summary>
        /// Send Email using 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static bool SendEmail(this Order order)
        {
            // Implement Code to send Email
            return true;
        }
        #endregion
    }
}
