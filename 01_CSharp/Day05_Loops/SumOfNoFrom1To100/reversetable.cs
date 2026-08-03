using System;

class reversetable
{
    public void multiplicationtable()
    {
        Console.WriteLine("Enter the number:");
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i=10; i>=1; i--)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
}
