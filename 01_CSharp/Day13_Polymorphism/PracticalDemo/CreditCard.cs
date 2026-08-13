using System;
class CreditCard:Payment
{
    public override void Pay()
    {
        Console.WriteLine("Credit Card Payment");
    }
}