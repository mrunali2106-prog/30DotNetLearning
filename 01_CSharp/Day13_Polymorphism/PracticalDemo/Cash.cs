using System;
class Cash:Payment
{
    public override void Pay()
    {
        Console.WriteLine("Cash payment method");
    }
}