using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public abstract class AbstractVehicle : IComparable<AbstractVehicle>
    {
        public VehicleCosts VehicleCosts { get; set; }
        public double AverageKilometers { get; set; }         

        public AbstractVehicle() { }

        public AbstractVehicle(VehicleCosts vehicleCosts, double averageKilometers) 
        {
            this.VehicleCosts = vehicleCosts;
            this.AverageKilometers = averageKilometers;
        }

        public abstract double GetTotalCosts();

        public override string ToString() => $"{VehicleCosts.Name};{VehicleCosts.AverageCostKilometer};{AverageKilometers}"
                                .Replace(',', '.').Replace(';', ','); //Fix replacing ',' in numbers with '.'

        public int CompareTo(AbstractVehicle second) 
        {
            if (GetTotalCosts() < second.GetTotalCosts()) return -1;
            else if (GetTotalCosts() > second.GetTotalCosts()) return 1;
            else return 0;
        }
    }
}
