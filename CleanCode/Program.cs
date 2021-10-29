using System;
using CleanCode.Models;
using CleanCode.Services;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var userToto = new User ("Toto"){TotalMoneySpent = 1500};
            var userTata = new User ("Tata"){TotalMoneySpent = 500};
            IDiscountService discountService = new DiscountService();

            Console.WriteLine($"Discount in percent of {userToto.Name}: {userToto.GetDiscountInPercent}");
            Console.WriteLine($"Discount in percent of {userTata.Name}: {userTata.GetDiscountInPercent}");



            Console.WriteLine($"DiscountService {new DiscountServiceUgly().GD(50, 20, 1)}");
            Console.WriteLine($"DiscountService {discountService.GetDiscountedPrice(50, 20)}");
        }
    }
}
