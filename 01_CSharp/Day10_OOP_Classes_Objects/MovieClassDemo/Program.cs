using System;
class Movie
{
    public string MovieName;
    public int ReleaseYear;
    public void DisplayMovie()
    {
        Console.WriteLine("movie released....")
    }
}
class Program()
{
    static void Main()
    {
        Movie m = new Movie();
        m.MovieName="3 idiots";
        m.ReleaseYear = 2010;
        Console.WriteLine(m.MovieName);
        Console.WriteLine(m.ReleaseYear);
        m.DisplayMovie();
    }
} 