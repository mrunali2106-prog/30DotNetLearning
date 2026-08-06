using System;
class Program
{
    static int Add(int n1, int n2)
    {
        return n1 + n2;
    }
    static int sub(int n1, int n2)
    {
        return n1 - n2;
    }
    static int mul(int n1, int n2)
    {
        return n1 * n2;
    }
    static int div(int n1, int n2)
    {
        return n1 / n2;
    }
    static void Main()
    {
        Console.WriteLine("Enter no 1:");
        int no1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter no 2:");
        int no2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Select Operation: 1.Add 2.Subtract 3.Multiplicatiom 4.Division");
        int ch = Convert.ToInt32(Console.ReadLine());
        int res = 0;
        switch(ch)
            {
            case 1:
               res= Add(no1, no2);
                break;
            case 2:
               res= sub(no1, no2);
                break;
            case 3:
               res= mul(no1, no2);
                break;
            case 4:
                res=div(no1, no2);
                break;
            default:
                Console.WriteLine("invalid choice");
                break;
            }
        Console.WriteLine("result :" + res);
        }
    }