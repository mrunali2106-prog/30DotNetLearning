using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichDemo
{
    internal class ResturantMenu
    {
        public void ShowMenu()
        {
            Console.WriteLine("Resturant Menu:");
            Console.WriteLine("1. Pizza");
            Console.WriteLine("2. Burger");
            Console.WriteLine("3. Sandwich");
            Console.WriteLine("Enter your choice(1-3):");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("pizza price is 250");
                    break;
                case 2:
                    Console.WriteLine("burger price is 150");
                    break;
                case 3:
                    Console.WriteLine("sandwich price is 100");
                    break;
                default:
                    Console.WriteLine("Food not Available");
                    break;

            }
        }
    }
}
