using CleanCode.Models;

namespace CleanCode.Services
{
    public class DiscountService : IDiscountService
    {
        public const double NO_DISCOUNT = 0;
        private const double PERCENT_100 = 100;

        public decimal GetDiscountedPrice(decimal price, decimal discountInPercent) =>
            price - GetDiscount(price, discountInPercent);

        private static decimal GetDiscount(decimal price, decimal discountInPercent) =>
            price * discountInPercent / (decimal) PERCENT_100;

    }
}
