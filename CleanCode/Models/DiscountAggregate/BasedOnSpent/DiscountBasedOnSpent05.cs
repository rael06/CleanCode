namespace CleanCode.Models.DiscountAggregate.BasedOnSpent
{
    public class DiscountBasedOnSpent05 : IDiscount
    {
        private const double PERCENT_05 = 5;
        public double Value => PERCENT_05;
    }
}
