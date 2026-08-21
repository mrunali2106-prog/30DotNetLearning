class Payment
{
    public virtual void Pay()
    {
        Console.WriteLine("There are 3 types of payment");
    }
}
class UPIPayment:Payment
{
    public override void Pay()
    {
        Console.WriteLine("Payment done by UPI");
    }
}
class CreditCardPayment:Payment
{
    public override void Pay()
    {
        Console.WriteLine("Payment done by Credit card");
    }
}
class Cash:Payment
{
    public override void Pay()
    {
        Console.WriteLine("payment done by cash");
    }
}
class Program
{
    static void Main()
    {
        Payment payment;
        payment = new CreditCardPayment();
        payment.Pay();
        payment = new Cash();
        payment.Pay();
        payment = new UPIPayment();
        payment.Pay();

    }
}