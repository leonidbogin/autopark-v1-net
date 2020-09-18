using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleSurcharge : AbstractVehicle
    {
        public decimal surchargeKilometer { get; set; }

        public VehicleSurcharge() { }

        public VehicleSurcharge(string name, decimal averageCostKilometer, decimal averageKilometers, decimal surchargeKilometer)
        {
            this.vehicleCosts = new VehicleCosts(name, averageCostKilometer); ;
            this.averageKilometers = averageKilometers;
            this.surchargeKilometer = surchargeKilometer;
        }

        public override decimal GetTotalCosts() => (vehicleCosts.averageCostKilometer + surchargeKilometer) * averageKilometers;
    }
}
