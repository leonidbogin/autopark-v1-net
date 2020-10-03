using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class Vehicle : IComparable
    {
        public string Name { get; set; }
        public double AverageCostKilometer { get; set; }        //BYN (cost - 1 km)
        public double AverageKilometers { get; set; }           //Km (kilometers - 1 month)
        public YearsOperation EndOperation { get; set; }        //Year (from enum)

        public Vehicle() { }

        public Vehicle(string name, double averageCostKilometer, double averageKilometers, YearsOperation endOperation) 
        {
            this.Name = name;
            this.AverageCostKilometer = averageCostKilometer;
            this.AverageKilometers = averageKilometers;
            this.EndOperation = endOperation;
        }

        public double GetTotalCosts() => AverageCostKilometer * AverageKilometers;

        public override string ToString() => $"{Name};{AverageCostKilometer};{AverageKilometers};{EndOperation}"
                                .Replace(',', '.').Replace(';', ','); //Fix replacing ',' in numbers with '.'

        public int CompareTo(object obj) 
        {
            Vehicle v = (Vehicle)obj;
            if (GetTotalCosts() < v.GetTotalCosts()) return -1;
            else if (GetTotalCosts() > v.GetTotalCosts()) return 1;
            else return 0;
        }
    }
}
