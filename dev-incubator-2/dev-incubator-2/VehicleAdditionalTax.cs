using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleAdditionalTax : AbstractVehicle
    {
        const double additionalTax = 2.1d;

        public VehicleAdditionalTax() { }

        public VehicleAdditionalTax(string name, double averageCostKilometer, double averageKilometers)
        {
            vehicleCosts = new VehicleCosts(name, averageCostKilometer);
            this.averageKilometers = averageKilometers; 
        }

        public override double GetTotalCosts() => 
            vehicleCosts.averageCostKilometer * averageKilometers + additionalTax;
    }
}
