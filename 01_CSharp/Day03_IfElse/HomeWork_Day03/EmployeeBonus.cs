using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Day03
{
    internal class EmployeeBonus
    {
        public void EmployessBonus()
        {
            Console.WriteLine("Enter the employee's salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            if(salary>=50000)
            {
                Console.WriteLine("10000 bonus");
            }
            else
            {
                Console.WriteLine("5000 bonus");
            }
        }
    }
}
