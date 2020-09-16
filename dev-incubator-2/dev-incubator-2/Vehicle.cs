using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class Vehicle : IComparable
    {
        public string name { get; set; }
        public double averageCost { get; set; }                 //BYN (cost - 1 km)
        public double averageKilometers { get; set; }           //Km (kilometers - 1 month)
        public YearsOperation startOperation { get; set; }      //Year (from enum)

        public Vehicle() { }

        public Vehicle(string name, double averageCost, double averageKilometers, YearsOperation startOperation) 
        {
            this.name = name;
            this.averageCost = averageCost;
            this.averageKilometers = averageKilometers;
            this.startOperation = startOperation;
        }

        public double GetTotalCosts() => averageCost * averageKilometers;

        public override string ToString() => "{name},{averageCost},{averageKilometers},{startOperation}";

        public int CompareTo(object obj) 
        {
            Vehicle v = (Vehicle)obj;
            if (GetTotalCosts() < v.GetTotalCosts()) return -1;
            else if (GetTotalCosts() > v.GetTotalCosts()) return 1;
            else return 0;
        }
    }
}
