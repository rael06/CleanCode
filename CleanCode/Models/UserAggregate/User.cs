using CleanCode.Models.DiscountAggregate;

namespace CleanCode.Models.UserAggregate
{
    public class User
    {
        public string Name { get; }
        public decimal TotalMoneySpent { get; init; }
        public uint SponsorshipNumber { get; init; }
        public IDiscount Discount => DiscountFactory.CreateDiscount(this);

        public User(string name)
        {
            Name = name;
        }

    }
}
