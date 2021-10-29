namespace CleanCode.Models.DiscountAggregate.BasedOnSpent
{
    public class DiscountBasedOnSpent05 : IDiscount
    {
        private const double PERCENT_05 = 5;
        public double GetDiscount() => PERCENT_05;
    }
}
