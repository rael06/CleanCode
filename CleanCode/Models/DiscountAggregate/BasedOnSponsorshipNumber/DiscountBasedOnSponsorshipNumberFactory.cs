using System;
using CleanCode.Models.UserAggregate;

namespace CleanCode.Models.DiscountAggregate.BasedOnSpent
{
    public static class DiscountBasedOnSponsorshipNumberFactory
    {
        public static IDiscount CreateDiscount(User user) =>
            new DiscountBasedOnSponsorshipNumber(user);
    }
}
