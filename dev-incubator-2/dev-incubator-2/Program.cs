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
            VehicleCollection vehicleCollection = new VehicleCollection(args[0]);

            Console.WriteLine("Аfter creation:");
            vehicleCollection.Print();

            VehicleCollection vehicleCollectionSecond = new VehicleCollection(args[1]);
            vehicleCollection.Insert(1, vehicleCollectionSecond.Vehicles.Last());
            vehicleCollection.Insert(150, vehicleCollectionSecond.Vehicles[1]);
            vehicleCollection.Insert(3, vehicleCollectionSecond.Vehicles[3]);
            vehicleCollection.Delete(2);
            vehicleCollection.Delete(8);
            vehicleCollection.Delete(-1);

            Console.WriteLine("Before sorting:");
            vehicleCollection.Print();

            IComparer<AbstractVehicle> comparer = new VehicleComparer();
            vehicleCollection.Sort(comparer);

            Console.WriteLine("After sorting:");
            vehicleCollection.Print();

            Console.WriteLine("Searching results:");
            Search(vehicleCollection, vehicleCollectionSecond, 1);
            Search(vehicleCollection, vehicleCollectionSecond, 2);

            Console.ReadLine();
        }

        private static void Search(VehicleCollection collection1, VehicleCollection collection2, int secondIndex)
        {
            int firstIndex = collection1.Vehicles.BinarySearch(collection2.Vehicles[secondIndex]);
            if (firstIndex > -1) 
                Console.WriteLine($"Item {collection2.Vehicles[secondIndex].ToString()} found on position {firstIndex}");
            else 
                Console.WriteLine($"Item {collection2.Vehicles[secondIndex].ToString()} not found");
        }
    }
}
