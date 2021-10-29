namespace CleanCode.Models.DiscountAggregate.BasedOnSpent
{
    public class DiscountBasedOnSpent15 : IDiscount
    {
        private const double PERCENT_15 = 15;
        public double GetDiscount() => PERCENT_15;
    }
}
