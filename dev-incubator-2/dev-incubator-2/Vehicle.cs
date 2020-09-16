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
        public double averageCostKilometer { get; set; }                 //BYN (cost - 1 km)
        public double averageKilometers { get; set; }           //Km (kilometers - 1 month)
        public YearsOperation endOperation { get; set; }      //Year (from enum)

        public Vehicle() { }

        public Vehicle(string name, double averageCostKilometer, double averageKilometers, YearsOperation endOperation) 
        {
            this.name = name;
            this.averageCostKilometer = averageCostKilometer;
            this.averageKilometers = averageKilometers;
            this.endOperation = endOperation;
        }

        public double GetTotalCosts() => averageCostKilometer * averageKilometers;

        public override string ToString() => "{name},{averageCostKilometer},{averageKilometers},{endOperation}";

        public int CompareTo(object obj) 
        {
            Vehicle v = (Vehicle)obj;
            if (GetTotalCosts() < v.GetTotalCosts()) return -1;
            else if (GetTotalCosts() > v.GetTotalCosts()) return 1;
            else return 0;
        }
    }
}
