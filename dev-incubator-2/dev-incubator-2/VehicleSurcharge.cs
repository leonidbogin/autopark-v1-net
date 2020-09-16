using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleSurcharge : Vehicle
    {
        public VehicleSurcharge() { }

        public VehicleSurcharge(string name, double averageCostKilometer, double averageKilometers, YearsOperation endOperation)
        {
            this.name = name;
            this.averageCostKilometer = averageCostKilometer;
            this.averageKilometers = averageKilometers;
            this.endOperation = endOperation;
        }

        const double surcharge = 0.5;
        public override double GetTotalCosts() => (averageCostKilometer + surcharge) * averageKilometers;
    }
}
