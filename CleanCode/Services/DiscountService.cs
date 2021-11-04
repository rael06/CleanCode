namespace CleanCode.Services
{
    public class DiscountService : IDiscountService
    {
        private const double PERCENT_100 = 100;

        public decimal GetDiscountedPrice(decimal price, double discountInPercent) =>
            price - GetDiscount(price, discountInPercent);

        private static decimal GetDiscount(decimal price, double discountInPercent) =>
            (decimal)((double)price * discountInPercent / PERCENT_100);
    }
}
