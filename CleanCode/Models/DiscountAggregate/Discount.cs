namespace CleanCode.Models.DiscountAggregate
{
    public class Discount : IDiscount
    {
        public double Value { get; }
        public Discount(double value)
        {
            Value = value;
        }
    }
}
