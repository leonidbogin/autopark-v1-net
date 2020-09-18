using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleAdditionalTax : AbstractVehicle
    {
        public decimal additionalTax { get; set; }

        public VehicleAdditionalTax() { }

        public VehicleAdditionalTax(string name, decimal averageCostKilometer, decimal averageKilometers, decimal additionalTax)
        {
            vehicleCosts = new VehicleCosts(name, averageCostKilometer);
            this.averageKilometers = averageKilometers;
            this.additionalTax = additionalTax;
        }

        public override decimal GetTotalCosts() => 
            vehicleCosts.averageCostKilometer * averageKilometers + additionalTax;
    }
}
