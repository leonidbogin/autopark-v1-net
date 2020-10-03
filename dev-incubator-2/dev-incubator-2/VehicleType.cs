using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleType
    {
        public string TypeName { get; set; }
        public double AveragePrice { get; set; }   //BYN
        public double CostGarage { get; set; }     //BYN
        public int Count { get; set; }

        public VehicleType() { }

        public VehicleType(string typeName, double averagePrice, double costGarage, int count)
        {
            this.TypeName = typeName;
            this.AveragePrice = averagePrice;
            this.CostGarage = costGarage;
            this.Count = count;
        }

        public double GetTotal() => CostGarage * Count + AveragePrice;

        public void Display()
        {
            Console.WriteLine($"TypeName = {TypeName};");
            Console.WriteLine($"AveragePrice = {AveragePrice};");
            Console.WriteLine($"Garage = {CostGarage};");
            Console.WriteLine($"NumOfVehicles = {Count};");
            Console.WriteLine($"Total = {GetTotal()};");
        }

        public override string ToString() => $"{TypeName},{AveragePrice},{CostGarage},{Count},{GetTotal()}";
    }
}
