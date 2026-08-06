using System;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter First Number:");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result:"+(n1+n2));
        }
        catch(Exception ex) 
        {
            Console.WriteLine("Error:"+ex.Message);
        }
        finally
        {
            Console.WriteLine("Program Finished Successfully.");
        }
    }
}
