namespace OrderProcessing.Common
{
    public class Order
    {
        public Customer CustomerDetail { get; set; }
        public Product ProductDetail { get; set; }
        public Agent AgentDetail { get; set; }
    }
}
