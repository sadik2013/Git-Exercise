using System;

namespace OPPApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person onePerson= new Person();
            onePerson.FirstName = "Rafiqul";
            onePerson.MiddleName = "Islam";
            onePerson.LastName = "Sadik";

            Console.WriteLine(onePerson.GetFullName());

            onePerson.RoadNo = "11";
            onePerson.HouseNo = "19";
            onePerson.City = "Uttara";
            onePerson.Sector = "9";

            Console.WriteLine(onePerson.FullAddress());

            Console.ReadKey();
        }
    }
}
