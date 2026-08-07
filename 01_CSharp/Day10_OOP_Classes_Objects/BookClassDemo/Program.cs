using System;
class Book
{
    public string Title;
    public string Author;
}
class Program
{
    static void Main()
    {
        Book book = new Book();
        book.Title="Test";
        book.Author="Test";
        Console.WriteLine(book.Title);
        Console.WriteLine(book.Author);
    }
}