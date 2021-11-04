using System;
using System.Collections.Generic;
using CleanCode.Models.UserAggregate;
using CleanCode.Services;

namespace CleanCode
{
    internal static class Program
    {
        private static readonly IDiscountService discountService = new DiscountService();

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


            users.ForEach(DisplayTotalPriceInfo);
        }

        private static void DisplayTotalPriceInfo(User user)
        {
            Console.WriteLine($"Price before discount of {user.Name}: {user.TotalMoneySpent}");
            Console.WriteLine($"Discount in percent of {user.Name}: {user.Discount.Value}");
            Console.WriteLine(
                $"Price after discount for {user.Name}: {discountService.GetDiscountedPrice(user.TotalMoneySpent, user.Discount.Value)}");
            Console.WriteLine();
        }
    }
}
