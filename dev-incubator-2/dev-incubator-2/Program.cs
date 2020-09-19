using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleCollection vehicleCollection = new VehicleCollection(args[0]);
            GarageStack garageStack = new GarageStack();

            for (int i = 0; i < vehicleCollection.vehicles.Count; i++)
            {
                garageStack.Input(vehicleCollection.vehicles[i]);
                Console.WriteLine($"Car {i}:\tdrove in garage [{vehicleCollection.vehicles[i].ToString()}]");
            }
            Console.WriteLine("< Garage is full >");
            for (int i = garageStack.Count()-1; i >= 0; i--)
            {
                Console.WriteLine($"Car {i}:\tleft the garage [{garageStack.Output().ToString()}]");
            }

            Console.ReadLine();
        }
    }
}
