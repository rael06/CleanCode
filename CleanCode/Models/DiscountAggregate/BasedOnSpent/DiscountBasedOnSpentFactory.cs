using CleanCode.Models.UserAggregate;

namespace CleanCode.Models.DiscountAggregate.BasedOnSpent
{
    public static class DiscountBasedOnSpentFactory
    {
        private const decimal MIN_SPENT_MONEY_FOR_DISCOUNT_05 = 1000m;
        private const decimal MIN_SPENT_MONEY_FOR_DISCOUNT_10 = 3000m;
        private const decimal MIN_SPENT_MONEY_FOR_DISCOUNT_15 = 7500m;
        private const decimal MIN_SPENT_MONEY_FOR_DISCOUNT_20 = 10000m;

        public static IDiscount CreateDiscount(User user)
        {
            return user.TotalMoneySpent switch
            {
                > MIN_SPENT_MONEY_FOR_DISCOUNT_20 => new DiscountBasedOnSpent20(),
                > MIN_SPENT_MONEY_FOR_DISCOUNT_15 => new DiscountBasedOnSpent15(),
                > MIN_SPENT_MONEY_FOR_DISCOUNT_10 => new DiscountBasedOnSpent10(),
                > MIN_SPENT_MONEY_FOR_DISCOUNT_05 => new DiscountBasedOnSpent05(),
                _ => new NoDiscount(),
            };
        }
    }
}
