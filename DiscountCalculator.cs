namespace Advanced_Concepts
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            product.Title = "Product Title";
            return 0;
        }

    }

    public class Product
    {
        public int Price { get; set; }
        public string Title { get; set; }
        
    }
}