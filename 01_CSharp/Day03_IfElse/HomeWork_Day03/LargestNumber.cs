using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Day03
{
    internal class LargestNumber
    {
        public void LagrestNum()
        {
            Console.WriteLine("Enter First number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
           
            if (num1 > num2 )
            {
                Console.WriteLine("The largest number is: " + num1);
            }
            
            else
            {
                Console.WriteLine("The largest number is: " + num2);
            }
        }
    }
}
