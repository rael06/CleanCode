namespace CleanCode
{
    public class DiscountService
    {
        // GD = GetDiscount
        public decimal GD(decimal t, decimal p, int s)
        {
            if (s == 0)
            {
                return t;
            }

            if (s == 1)
            {
                return t * ((100 - p) / 100);
            }

            return t;
        }
    }
}
