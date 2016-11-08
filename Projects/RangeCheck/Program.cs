using System;


namespace RangeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfItems = 52;
            int[] discountRangeLowLimits = { 1,   13,   50,  100,  200 };
            double[] discounts =           { 0, 0.10, 0.14, 0.18, 0.20 };

            double customerDiscount;
            int sub = discountRangeLowLimits.Length - 1;

            while(sub >= 0 && numOfItems < discountRangeLowLimits[sub])
                --sub;
            customerDiscount = discounts[sub];

            Console.WriteLine("Custromer discount is " + customerDiscount);

            Console.WriteLine();

            for (int f = 0; f < 3; ++f);
                Console.Write("{0} ", f);

        }
    }
}
