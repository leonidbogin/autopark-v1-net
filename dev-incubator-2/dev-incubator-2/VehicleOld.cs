using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleOld : Vehicle
    { 
        private static readonly double surchargeOld = 1.1;
        private static readonly int startOld = 5;

        public YearsOperation StartOperation { get; set; }
        public VehicleOld() { }

        public VehicleOld(string name, double averageCostKilometer, double averageKilometers, YearsOperation startOperation, YearsOperation endOperation)
        {
            this.Name = name;
            this.AverageCostKilometer = averageCostKilometer;
            this.AverageKilometers = averageKilometers;
            this.StartOperation = startOperation;
            this.EndOperation = endOperation;
        }       

        public override double GetTotalCosts() 
        {
            double surcharge = 0;
            int end = 0;
            if (EndOperation != YearsOperation.Operation)
                end = (int)EndOperation;
            else end = 2020;
            if (end - (int)StartOperation < -1
                || end - (int)StartOperation > startOld)
            {
                surcharge = surchargeOld;
            }
            return (AverageCostKilometer + surcharge) * AverageKilometers;
        }

        public override string ToString() => $"{Name};{AverageCostKilometer};{AverageKilometers};{StartOperation};{EndOperation}"
                                .Replace(',', '.').Replace(';', ','); //Fix replacing ',' in numbers with '.'
    }
}
