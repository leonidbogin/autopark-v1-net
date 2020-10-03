using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleSurcharge : AbstractVehicle
    {
        public decimal SurchargeKilometer { get; set; }

        public VehicleSurcharge() { }

        public VehicleSurcharge(string name, decimal averageCostKilometer, decimal averageKilometers, decimal surchargeKilometer)
        {
            this.VehicleCosts = new VehicleCosts(name, averageCostKilometer); ;
            this.AverageKilometers = averageKilometers;
            this.SurchargeKilometer = surchargeKilometer;
        }

        public override decimal GetTotalCosts() => (VehicleCosts.AverageCostKilometer + SurchargeKilometer) * AverageKilometers;
    }
}
