using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            VehicleType[] vehicles = new VehicleType[n];
            vehicles[0] = new VehicleType("Buses", 3000, 10000, 5);
            vehicles[1] = new VehicleType("Trucks", 5000, 20000, 2);
          //vehicles[2]
            vehicles[3] = new VehicleType("Cars", 900, 1000, 10);
            vehicles[4] = new VehicleType();

            foreach (VehicleType vehicle in vehicles)
            {
                if (vehicle != null) vehicle.Display();
                else Console.WriteLine("NULL");
                Console.WriteLine();
            }

            vehicles[n-1].costGarage = 5000;

            Console.WriteLine($"NumOfVehicles[{n-2}] + NumOfVehicles[{n - 1}] = " 
                                + (vehicles[n-2].count + vehicles[n-1].count).ToString() + "\n");

            foreach (VehicleType vehicle in vehicles)
            {
                if (vehicle != null) Console.WriteLine(vehicle.ToString());
                else Console.WriteLine("NULL");
            }

            Console.ReadLine();
        }
    }
}
