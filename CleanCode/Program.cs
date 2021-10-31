using System;
using System.Collections.Generic;
using CleanCode.Models;
using CleanCode.Models.UserAggregate;
using CleanCode.Services;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>
            {
                new("Toto") {TotalMoneySpent = 1000, SponsorshipNumber = 1},
                new("Titi") {TotalMoneySpent = 1001, SponsorshipNumber = 10},
                new("Tata") {TotalMoneySpent = 3001, SponsorshipNumber = 20},
                new("Tutu") {TotalMoneySpent = 7501, SponsorshipNumber = 30},
                new("Tete") {TotalMoneySpent = 10001, SponsorshipNumber = 40}
            };

            IDiscountService discountService = new DiscountService();

            users.ForEach(user =>
                Console.WriteLine($"Discount in percent of {user.Name}: {user.Discount.Value}")
            );


            Console.WriteLine($"DiscountService {new DiscountServiceUgly().GD(50, 20, 1)}");
            Console.WriteLine($"DiscountService {discountService.GetDiscountedPrice(50, 20)}");
        }
    }
}
