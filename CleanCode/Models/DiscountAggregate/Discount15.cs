namespace CleanCode.Models.DiscountAggregate
{
    public class Discount15 : AbstractDiscount
    {
        private const double PERCENT_15 = 15;
        public override double Discount { get; set; } = PERCENT_15;
    }
}
