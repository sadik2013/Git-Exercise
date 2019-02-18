using System;
using System.Collections.Generic;
using System.Text;

namespace OPPApp
{
    public class Address
    {
        public string HouseNo { get; set; }
        public string RoadNo { get; set; }
        public string Sector { get; set; }
        public string City { get; set; }

        public string FullAddress()
        {
            return "House No:" + HouseNo + " " + "Road No:" + RoadNo + "Sector:" + Sector + " " + "City:" + City;
        }
    }
}
