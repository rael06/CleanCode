using CleanCode.Models.DiscountAggregate;

namespace CleanCode.Models
{
    public class NoDiscount : AbstractDiscount
    {
        private const double NO_DISCOUNT = 0;
        public override double Discount { get; set; } = NO_DISCOUNT;
    }
}
