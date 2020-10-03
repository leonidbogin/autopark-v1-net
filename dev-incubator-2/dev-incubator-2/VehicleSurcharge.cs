using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleSurcharge : Vehicle
    {
        private static readonly double surcharge = 0.5;
        public VehicleSurcharge() { }

        public VehicleSurcharge(string name, double averageCostKilometer, double averageKilometers, YearsOperation endOperation)
        {
            this.Name = name;
            this.AverageCostKilometer = averageCostKilometer;
            this.AverageKilometers = averageKilometers;
            this.EndOperation = endOperation;
        }
        public override double GetTotalCosts() => (AverageCostKilometer + surcharge) * AverageKilometers;
    }
}
