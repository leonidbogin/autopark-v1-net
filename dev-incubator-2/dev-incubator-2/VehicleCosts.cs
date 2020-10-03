using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleCosts
    {
        public string Name { get; set; }
        public decimal AverageCostKilometer { get; set; }    //BYN (cost - 1 km)

        public VehicleCosts() { }

        public VehicleCosts(string name, decimal averageCostKilometer)
        {
            this.Name = name;
            this.AverageCostKilometer = averageCostKilometer;
        }
    }
}
