namespace CleanCode.Models.DiscountAggregate.BasedOnSpent
{
    public class DiscountBasedOnSpent20 : IDiscount
    {
        private const double PERCENT_20 = 20;
        public double Value => PERCENT_20;
    }
}
