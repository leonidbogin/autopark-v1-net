using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleComparer : IComparer<AbstractVehicle>
    {
        public int Compare(AbstractVehicle x, AbstractVehicle y)
        {
            int result = (x.vehicleCosts.name).CompareTo(y.vehicleCosts.name);
            if (result != 0)
            {
                return result;
            }
            else
            {
                return (x.GetTotalCosts()).CompareTo(y.GetTotalCosts());
            }
        }
    }
}
