namespace CleanCode.Models.DiscountAggregate
{
    public class Discount05 : AbstractDiscount
    {
        private const double PERCENT_05 = 5;
        public override double Discount { get; set; } = PERCENT_05;
    }
}
