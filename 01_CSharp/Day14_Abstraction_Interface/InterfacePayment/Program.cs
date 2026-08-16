class Program
{
    static void Main()
    {
        IPayment cash = new CashPayment();
        cash.Pay();
        IPayment Card = new CardPayment();
        Card.Pay();
        IPayment UPI=new UPIPayment();
        UPI.Pay();
    }
}