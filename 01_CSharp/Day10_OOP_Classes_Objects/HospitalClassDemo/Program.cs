using System;
class Hospital
{
    public string DoctorName;
    public string Department;
    public void display()
    {
        Console.WriteLine("Doctor Name::" + DoctorName);
        Console.WriteLine("Department:"+Department);
    }
}
class Program
{
    static void Main()
    {
        Hospital hospital = new Hospital();
        hospital.DoctorName = "AbC";
        hospital.Department = "xyx";
        hospital.display();
    }
}