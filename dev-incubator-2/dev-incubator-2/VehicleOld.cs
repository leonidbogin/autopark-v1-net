using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleOld : AbstractVehicle
    {
        private static readonly int startOldAge = 5;
        private static readonly double surchargeOld = 0.6d;
        private readonly int age;
        public YearsOperation EndOperation { get; set; }
        public VehicleOld() { }

        public VehicleOld(string name, double averageCostKilometer, double averageKilometers, YearsOperation endOperation, int age)
        {
            VehicleCosts = new VehicleCosts(name, averageCostKilometer);
            this.AverageKilometers = averageKilometers;
            this.EndOperation = endOperation;
            this.age = age;
        }       

        public override double GetTotalCosts() 
        {
            double surcharge = 0;
            if (age > startOldAge) surcharge = surchargeOld;
            return (VehicleCosts.AverageCostKilometer + surcharge) * AverageKilometers;
        }

        public override string ToString() => 
            $"{VehicleCosts.Name};{VehicleCosts.AverageCostKilometer};{AverageKilometers};{EndOperation};{age}"
            .Replace(',', '.').Replace(';', ','); //Fix replacing ',' in numbers with '.'
    }
}
