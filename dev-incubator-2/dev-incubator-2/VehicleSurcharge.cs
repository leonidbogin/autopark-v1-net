using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleSurcharge : AbstractVehicle
    {
        const double surcharge = 0.5;

        public VehicleSurcharge() { }

        public VehicleSurcharge(string name, double averageCostKilometer, double averageKilometers)
        {
            this.vehicleCosts = new VehicleCosts(name, averageCostKilometer); ;
            this.averageKilometers = averageKilometers;
        }

        public override double GetTotalCosts() => (vehicleCosts.averageCostKilometer + surcharge) * averageKilometers;
    }
}
