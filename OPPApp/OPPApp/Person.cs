using System;
using System.Collections.Generic;
using System.Text;

namespace OPPApp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public  string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }


    }
}
