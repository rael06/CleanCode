using System;
using CleanCode.Models.UserAggregate;

namespace CleanCode.Models.DiscountAggregate.BasedOnSpent
{
    public class DiscountBasedOnSponsorshipNumber : IDiscount
    {
        private const uint DISCOUNT_LIMIT = 4;
        private const double SPONSORSHIP_NUMBER_GAP = 10;

        private User User { get; set; }

        public DiscountBasedOnSponsorshipNumber(User user)
        {
            User = user;
        }

        public double GetDiscount() =>
            Math.Min(DISCOUNT_LIMIT, Math.Floor(User.SponsorshipNumber / SPONSORSHIP_NUMBER_GAP));
    }
}
