namespace OrderProcessing.Common
{
    public class Product
    {
        public ProductCatagories Catagories { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
    public enum ProductCatagories
    {

        Books,
        Physical,
        SkiLearningvideos,
        Membership,
        UpgradedMemberShip
    }
}