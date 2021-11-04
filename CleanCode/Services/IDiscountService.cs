namespace CleanCode.Services
{
    public interface IDiscountService
    {
        public decimal GetDiscountedPrice(decimal price, double discountInPercent);
    }
}
