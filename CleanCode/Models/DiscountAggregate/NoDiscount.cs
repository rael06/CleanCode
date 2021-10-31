using CleanCode.Models.DiscountAggregate;

namespace CleanCode.Models
{
    public class NoDiscount : IDiscount
    {
        private const double NO_DISCOUNT = 0;
        public double Value => NO_DISCOUNT;
    }
}
