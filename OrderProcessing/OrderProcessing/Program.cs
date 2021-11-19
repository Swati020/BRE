using OrderProcessing.Common;
using System;
using System.Collections.Generic;

namespace OrderProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Business Rule Engine");
            List<Order> processedOrderList = new List<Order>();
            Order orderPhysical = new Order()
            {
                CustomerDetail = new Customer { EmailId = "abc@gmail.com", Name = "TestName" },
                ProductDetail = new Product { Catagories = ProductCatagories.Physical, Quantity = 2, UnitPrice = 50 },
                AgentDetail = new Agent { AgentId = 1 }
            };
            PostPayment postPayment = new PostPayment();
            if (postPayment.PostPaymentProcessing(orderPhysical))
                Console.WriteLine("Processing Completed Successfully on the basis of Rules");
            else
                Console.WriteLine("Processing Failed");
        }
    }
}
