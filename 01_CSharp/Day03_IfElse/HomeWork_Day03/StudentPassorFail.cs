using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Day03
{
    internal class StudentPassorFail
    {
        public void StudentResult()
        {
            Console.WriteLine("Enter the student's marks");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks >= 35)
            {
                Console.WriteLine("The student has passed");
            }
            else
            {
                Console.WriteLine("The student has failed");
            }
        }
    }
}
