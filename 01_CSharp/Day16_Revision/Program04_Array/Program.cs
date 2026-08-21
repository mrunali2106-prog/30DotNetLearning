using System;
class Program
{
    static void Main()
    {
        int[] marks = { 70, 85, 60, 90, 75 };
        int total=0;
        int max = marks[0];
        int min = marks[0];
        for (int i = 0; i < marks.Length; i++)
        {
             total += marks[i];           
        }
        Console.WriteLine("Total:"+total);
        double average=(double)total/marks.Length;
        Console.WriteLine("Average :" + average);

            foreach (var mark in marks)
            {
                if (mark>max)
                {
                        
                        max= mark;
                }
                if (mark<min)

                {
                    min=mark;
                }
            }
        
        Console.WriteLine("Highest marks:"+max);
        Console.WriteLine("Lowest marks:" + min);

    }
}