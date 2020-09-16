using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleOld : Vehicle
    { 
        const double surchargeOld = 1.1;
        const int startOld = 5;

        public YearsOperation startOperation { get; set; }
        public VehicleOld() { }

        public VehicleOld(string name, double averageCostKilometer, double averageKilometers, YearsOperation startOperation, YearsOperation endOperation)
        {
            this.name = name;
            this.averageCostKilometer = averageCostKilometer;
            this.averageKilometers = averageKilometers;
            this.startOperation = startOperation;
            this.endOperation = endOperation;
        }       

        public override double GetTotalCosts() 
        {
            double surcharge = 0;
            int end = 0;
            if (endOperation != YearsOperation.Operation)
                end = (int)endOperation;
            else end = 2020;
            if (end - (int)startOperation < -1
                || end - (int)startOperation > startOld)
            {
                surcharge = surchargeOld;
            }
            return (averageCostKilometer + surcharge) * averageKilometers;
        }

        public override string ToString() => $"{name};{averageCostKilometer};{averageKilometers};{startOperation};{endOperation}"
                                .Replace(',', '.').Replace(';', ','); //Fix replacing ',' in numbers with '.'
    }
}
