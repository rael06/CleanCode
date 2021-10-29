using CleanCode.Models.DiscountAggregate;
using CleanCode.Services;

namespace CleanCode.Models.UserAggregate
{
    public class User
    {
        public string Name { get; set; }
        public decimal TotalMoneySpent { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public AbstractDiscount GetDiscount()
        {
            return DiscountFactory.CreateDiscount(this);
        }
    }
}
