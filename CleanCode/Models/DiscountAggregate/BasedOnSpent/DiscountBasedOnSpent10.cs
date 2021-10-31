namespace CleanCode.Models.DiscountAggregate.BasedOnSpent
{
    public class DiscountBasedOnSpent10 : IDiscount
    {
        private const double PERCENT_10 = 10;
        public double Value => PERCENT_10;
    }
}
