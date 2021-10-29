namespace CleanCode.Models.DiscountAggregate
{
    public class Discount10 : AbstractDiscount
    {
        private const double PERCENT_10 = 10;
        public override double Discount { get; set; } = PERCENT_10;
    }
}
