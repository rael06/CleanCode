namespace CleanCode.Models.DiscountAggregate
{
    public class Discount20 : AbstractDiscount
    {
        private const double PERCENT_20 = 20;
        public override double Discount { get; set; } = PERCENT_20;
    }
}
