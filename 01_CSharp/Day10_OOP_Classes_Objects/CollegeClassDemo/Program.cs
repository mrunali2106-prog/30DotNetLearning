using System;
class College
{
    public string CollegeName;
    public string City;
    public void CollegeInfo()
    {
        Console.WriteLine("College Name :"+CollegeName + "City :" +City);
    }
}
class Program()
{
    static void Main()
    {
        College college = new College();
        college.CollegeName = "MTB";
        college.City = "Surat";

        college.CollegeInfo();
    }
}