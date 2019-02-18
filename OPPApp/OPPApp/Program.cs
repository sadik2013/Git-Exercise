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





            Console.ReadKey();
        }
    }
}
