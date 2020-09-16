using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleType
    {
        public string typeName { get; set; }
        public double averagePrice { get; set; }   //BYN
        public double costGarage { get; set; }     //BYN
        public int count { get; set; }

        public VehicleType() { }

        public VehicleType(string typeName, double averagePrice, double costGarage, int count)
        {
            this.typeName = typeName;
            this.averagePrice = averagePrice;
            this.costGarage = costGarage;
            this.count = count;
        }

        public double GetTotal() => costGarage * count + averagePrice;

        public void Display()
        {
            Console.WriteLine($"TypeName = {typeName};");
            Console.WriteLine($"AveragePrice = {averagePrice};");
            Console.WriteLine($"Garage = {costGarage};");
            Console.WriteLine($"NumOfVehicles = {count};");
            Console.WriteLine($"Total = {GetTotal()};");
        }

        public override string ToString() => $"{typeName},{averagePrice},{costGarage},{count},{GetTotal()}";
    }
}
