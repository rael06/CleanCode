using System;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DiscountService"+ new DiscountService().GD(50, 20, 1));
            Console.WriteLine("DiscountService"+ new DiscountServiceClean().GetDiscountedPrice(50, 20));
        }
    }
}
