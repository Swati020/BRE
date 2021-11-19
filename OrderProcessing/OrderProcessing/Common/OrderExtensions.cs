namespace OrderProcessing.Common
{
    public static class OrderExtensions
    {
        /// <summary>
        /// If payment is for physical category
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static bool IsPhysical(this Order order)
        {
            return order.ProductDetail.Catagories == ProductCatagories.Physical;
        }
        /// <summary>
        /// If Payment is for book category
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static bool IsBook(this Order order)
        {
            return order.ProductDetail.Catagories == ProductCatagories.Books;
        }
        /// <summary>
        /// If payment is for category as membership
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static bool IsMember(this Order order)
        {
            return order.ProductDetail.Catagories == ProductCatagories.Membership;
        }
        /// <summary>
        /// Upgrade of member ship required or not
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static bool IsUpgraded(this Order order)
        {
            return order.ProductDetail.Catagories == ProductCatagories.UpgradedMemberShip;
        }
        /// <summary>
        /// EmailRequired will validate if email rule is applicable
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Validate the learning ski category 
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static bool IsLearningSkiVideo(this Order order)
        {
            return order.ProductDetail.Catagories == ProductCatagories.SkiLearningvideos;
        }
        /// <summary>
        /// Validate if Commision is applicable or not as per product category
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static bool IsCommisionRequired(this Order order)
        {
            if (order.IsPhysical() || order.IsBook())
            {
                return true;
            }
            else
            {
                return false;
            }
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
                if (order.IsLearningSkiVideo())
                {
                    // Add a video link in the payment slip pdf, also need to provide a downlodable zip of the First AID video as per regulations.
                }
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
