using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void DiscountDelegate(ref double salesAmount);

namespace DiscountDelegateDemo2
{
    class DiscountDelegateDemo
    {
        public static void StandardDiscount(ref double salesAmount)
        {
            const double DISCOUNT_RATE = 0.05;
            const double CUTOFF = 1000.00;
            double discount;

            if (salesAmount >= CUTOFF)
                discount = salesAmount * DISCOUNT_RATE;
            else
                discount = 0;
            salesAmount -= discount; 
        }
        public static void PreferredDiscount(ref double salesAmount)
        {
            const double SPECIAL_DISCOUNT = 0.10;
            double discount = salesAmount * SPECIAL_DISCOUNT;
            salesAmount -= discount;
        }

        static void Main(string[] args)
        {
            double saleAmount;
            char code;
            DiscountDelegate firstDel, secondDel, thirdDel;

            firstDel = new DiscountDelegate(StandardDiscount);
            secondDel = new DiscountDelegate(PreferredDiscount);

            thirdDel = firstDel;
            thirdDel += secondDel;

            Console.WriteLine("Enter amount of sale: ");
            saleAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter S for standard discount or P for the preferred discount " +
                "\nor X for Xtreme discount: " );

            code = Convert.ToChar(Console.ReadLine());

            if (code == 'S')
                firstDel(ref saleAmount);
            else 
                if (code == 'P')
                secondDel(ref saleAmount);
            else
                thirdDel(ref saleAmount);

            Console.WriteLine("New sale amount is {0}", saleAmount.ToString("C2"));


        }
    }
}
