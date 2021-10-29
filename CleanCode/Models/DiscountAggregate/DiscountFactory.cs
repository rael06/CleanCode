using CleanCode.Models.UserAggregate;

namespace CleanCode.Models.DiscountAggregate
{
    public static class DiscountFactory
    {
        private const decimal MIN_SPENT_MONEY_FOR_DISCOUNT_05 = 1000m;
        private const decimal MIN_SPENT_MONEY_FOR_DISCOUNT_10 = 3000m;
        private const decimal MIN_SPENT_MONEY_FOR_DISCOUNT_15 = 7500m;
        private const decimal MIN_SPENT_MONEY_FOR_DISCOUNT_20 = 10000m;

        public static AbstractDiscount CreateDiscount(User user)
        {
            return user.TotalMoneySpent switch
            {
                > MIN_SPENT_MONEY_FOR_DISCOUNT_20 => new Discount20(),
                > MIN_SPENT_MONEY_FOR_DISCOUNT_15 => new Discount15(),
                > MIN_SPENT_MONEY_FOR_DISCOUNT_10 => new Discount10(),
                > MIN_SPENT_MONEY_FOR_DISCOUNT_05 => new Discount05(),
                _ => new NoDiscount(),
            };
        }
    }
}
