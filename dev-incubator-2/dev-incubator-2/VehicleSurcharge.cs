using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleSurcharge : AbstractVehicle
    {
        private static readonly double surcharge = 0.5;

        public VehicleSurcharge() { }

        public VehicleSurcharge(string name, double averageCostKilometer, double averageKilometers)
        {
            this.VehicleCosts = new VehicleCosts(name, averageCostKilometer); ;
            this.AverageKilometers = averageKilometers;
        }

        public override double GetTotalCosts() => (VehicleCosts.AverageCostKilometer + surcharge) * AverageKilometers;
    }
}
