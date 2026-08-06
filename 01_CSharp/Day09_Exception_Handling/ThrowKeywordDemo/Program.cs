using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter Age :");
            int Age=Convert.ToInt32(Console.ReadLine());
            if(Age<0 )
            {
                throw new Exception("Age Can not be negative");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}