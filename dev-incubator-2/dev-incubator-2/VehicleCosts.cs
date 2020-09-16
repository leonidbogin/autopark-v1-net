using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleCosts
    {
        public string name;
        public double averageCostKilometer;     //BYN (cost - 1 km)

        public VehicleCosts() { }

        public VehicleCosts(string name, double averageCostKilometer)
        {
            this.name = name;
            this.averageCostKilometer = averageCostKilometer;
        }
    }
}
