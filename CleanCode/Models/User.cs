using CleanCode.Services;

namespace CleanCode.Models
{
    public class User
    {
        private const decimal MIN_SPENT_MONEY_FOR_DISCOUNT = 1000;
        private const double PERCENT_5 = 5;
        public string Name { get; set; }
        public decimal TotalMoneySpent { get; set; }
        public double GetDiscountInPercent =>
            TotalMoneySpent > MIN_SPENT_MONEY_FOR_DISCOUNT ? PERCENT_5 : DiscountService.NO_DISCOUNT;

        public User(string name)
        {
            Name = name;
        }
    }
}
