namespace CleanCode.Models.DiscountAggregate
{
    public class Discount : IDiscount
    {
        private readonly double value;
        public Discount(double value)
        {
            this.value = value;
        }

        public double GetDiscount()
        {
            return value;
        }
    }
}
