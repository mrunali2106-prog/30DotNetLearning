using System;
class CreditCard:Payment
{
    public override void Pay()
    {
        Console.WriteLine("Payment through creditcard");
    }
}