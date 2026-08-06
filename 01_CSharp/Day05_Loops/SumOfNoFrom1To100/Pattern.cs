using System;


namespace SumOfNoFrom1To100
{
    internal class Pattern
    {
        public void PrintPattern()
        {
            Console.WriteLine("Enter no:");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
               
            }
        }
    }
}
