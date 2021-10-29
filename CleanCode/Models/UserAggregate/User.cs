using System.Collections.Generic;
using CleanCode.Models.DiscountAggregate;
using CleanCode.Models.DiscountAggregate.BasedOnSpent;

namespace CleanCode.Models.UserAggregate
{
    public class User
    {
        public string Name { get; set; }
        public decimal TotalMoneySpent { get; set; }
        public uint SponsorshipNumber { get; set; }
        public IDiscount Discount => DiscountFactory.CreateDiscount(this);

        public User(string name)
        {
            Name = name;
        }

    }
}
