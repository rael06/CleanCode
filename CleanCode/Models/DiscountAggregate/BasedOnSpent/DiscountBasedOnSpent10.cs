namespace CleanCode.Models.DiscountAggregate.BasedOnSpent
{
    public class DiscountBasedOnSpent10 : IDiscount
    {
        private const double PERCENT_10 = 10;
        public double GetDiscount() => PERCENT_10;
    }
}
