abstract class Payment
{
    public abstract void Pay();
}
class UPI:Payment
{
    public override void Pay()
    {
        Console.WriteLine("Payment using UPI");
    }
}
class Card : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Payment using card");
    }
}
class Program
{
    static void Main()
    {
        Payment payment;
        payment = new UPI();
        payment.Pay();
        payment=new Card();
        payment.Pay();
    }
}