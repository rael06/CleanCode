using System.Collections.Generic;
using System.Linq;
using CleanCode.Models.DiscountAggregate.BasedOnSpent;
using CleanCode.Models.UserAggregate;

namespace CleanCode.Models.DiscountAggregate
{
    public static class DiscountFactory
    {
        public static IDiscount CreateDiscount(User user)
        {
            var discounts = new List<IDiscount>
            {
                DiscountBasedOnSpentFactory.CreateDiscount(user),
                DiscountBasedOnSponsorshipNumberFactory.CreateDiscount(user)
            };

            return new Discount(discounts.Sum(discount => discount.Value));
        }
    }
}
