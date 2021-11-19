using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Common
{
    public static class OrderExtensions
    {
        public static bool IsPhysical(this Order order)
        {
            return order.ProductDetail.Catagories == ProductCatagories.Physical;
        }
    }
}
