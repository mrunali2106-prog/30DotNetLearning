using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwichDemo
{
    internal class ATM_Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("ATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("Enter your choice(1-3):");
            int ch=Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Your Balance is $1000");
                    break;
                case 2:
                    Console.WriteLine("Money Deposited Successfully");
                    break;
                case 3:
                    Console.WriteLine("Money Withdrawn Successfully");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
