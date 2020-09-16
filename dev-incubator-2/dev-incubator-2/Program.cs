using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 9;

            AbstractVehicle[] vehicles = new AbstractVehicle[n];
            vehicles[0] = new VehicleSurcharge("МАЗ 5551", 4.5, 300);
            vehicles[1] = new VehicleSurcharge("МАЗ 5516", 4, 400);
            vehicles[2] = new VehicleSurcharge("Volkswagen Passat B5", 0.6, 800);
            vehicles[3] = new VehicleOld("Volkswagen Polo", 0.4, 400, YearsOperation.Y2020, 4);
            vehicles[4] = new VehicleOld("МАЗ 216", 2.8, 1200, YearsOperation.Operation, 6);
            vehicles[5] = new VehicleOld("МАЗ 200", 3, 1400, YearsOperation.Y2019, 18);
            vehicles[6] = new VehicleAdditionalTax("Volkswagen Golf 3", 0.4, 400);
            vehicles[7] = new VehicleAdditionalTax("МАЗ 210", 2.8, 800);
            vehicles[8] = new VehicleAdditionalTax("МАЗ 205", 3, 1000);

            DisplayVehicles(vehicles);

            Array.Sort(vehicles);

            Console.WriteLine();
            DisplayVehicles(vehicles);

            Console.ReadLine();
        }

        private static void DisplayVehicles(AbstractVehicle[] vehicles) 
        {
            foreach (AbstractVehicle vehicle in vehicles)
                Console.WriteLine(vehicle.ToString());
        }
    }
}
