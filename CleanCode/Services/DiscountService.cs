namespace CleanCode
{
    public class DiscountServiceClean
    {
        private const decimal PERCENT_100 = 100;

        public decimal GetDiscountedPrice(decimal price, decimal discountInPercent) =>
            price - GetDiscount(price, discountInPercent);

        private static decimal GetDiscount(decimal price, decimal discountInPercent) =>
            price * discountInPercent / PERCENT_100;


    }
}
