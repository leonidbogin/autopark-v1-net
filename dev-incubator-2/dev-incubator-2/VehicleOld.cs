using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleOld : AbstractVehicle
    { 
        readonly int age;
        const int startOldAge = 5;
        const double surchargeOld = 0.6d;

        public YearsOperation endOperation { get; set; }
        public VehicleOld() { }

        public VehicleOld(string name, double averageCostKilometer, double averageKilometers, YearsOperation endOperation, int age)
        {
            vehicleCosts = new VehicleCosts(name, averageCostKilometer);
            this.averageKilometers = averageKilometers;
            this.endOperation = endOperation;
            this.age = age;
        }       

        public override double GetTotalCosts() 
        {
            double surcharge = 0;
            if (age > startOldAge) surcharge = surchargeOld;
            return (vehicleCosts.averageCostKilometer + surcharge) * averageKilometers;
        }

        public override string ToString() => 
            $"{vehicleCosts.name};{vehicleCosts.averageCostKilometer};{averageKilometers};{endOperation};{age}"
            .Replace(',', '.').Replace(';', ','); //Fix replacing ',' in numbers with '.'
    }
}
