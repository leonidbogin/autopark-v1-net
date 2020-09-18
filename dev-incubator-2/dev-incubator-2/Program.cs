using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    class Program
    {
        static void Main(string[] args)
        {

            VehicleCollection vehicleCollection = new VehicleCollection();
            for (int i = 0; i < args.Length; i++)
            {
                vehicleCollection.AddFromFile(args[i]);
            }

            //Console.WriteLine("Аfter creation:");
            //vehicleCollection.Print();

            WashCars(vehicleCollection.vehicles); 

            Console.ReadLine();
        }

        private static void WashCars(List<AbstractVehicle> vehicles)
        {
            Queue<AbstractVehicle> queueWash = new Queue<AbstractVehicle>();

            foreach (AbstractVehicle vehicle in vehicles)
                queueWash.Enqueue(vehicle);

            Console.WriteLine("Wash:");
            while (queueWash.Count > 0)
            {
                Console.WriteLine("  Car: " + queueWash.Dequeue().ToString());
            }
        }

        private static void DisplayVehicles(AbstractVehicle[] vehicles) 
        {
            foreach (AbstractVehicle vehicle in vehicles)
                Console.WriteLine(vehicle.ToString());
        }
    }
}
