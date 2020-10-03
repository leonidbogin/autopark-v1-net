using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleAdditionalTax : AbstractVehicle
    {
        private static readonly double additionalTax = 2.1d;

        public VehicleAdditionalTax() { }

        public VehicleAdditionalTax(string name, double averageCostKilometer, double averageKilometers)
        {
            VehicleCosts = new VehicleCosts(name, averageCostKilometer);
            this.AverageKilometers = averageKilometers; 
        }

        public override double GetTotalCosts() => 
            VehicleCosts.AverageCostKilometer * AverageKilometers + additionalTax;
    }
}
