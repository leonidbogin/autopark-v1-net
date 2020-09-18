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

            Vehicle[] vehicles = new Vehicle[n];
            vehicles[0] = new Vehicle("МАЗ 5551", 4.5, 300, YearsOperation.Y2018);
            vehicles[1] = new Vehicle("МАЗ 5516", 4, 400, YearsOperation.Y2019);
            vehicles[2] = new Vehicle("Volkswagen Passat B5", 0.6, 800, YearsOperation.Operation);
            vehicles[3] = new VehicleSurcharge("Volkswagen Polo", 0.4, 400, YearsOperation.Y2020);
            vehicles[4] = new VehicleSurcharge("МАЗ 216", 2.8, 1200, YearsOperation.Operation);
            vehicles[5] = new VehicleSurcharge("МАЗ 200", 3, 1400, YearsOperation.Y2019);
            vehicles[6] = new VehicleOld("Volkswagen Golf 3", 0.4, 400, YearsOperation.Y2010, YearsOperation.Y2020);
            vehicles[7] = new VehicleOld("МАЗ 210", 2.8, 800, YearsOperation.Y2015, YearsOperation.Operation);
            vehicles[8] = new VehicleOld("МАЗ 205", 3, 1000, YearsOperation.Y2016, YearsOperation.Y2019);

            bool allEquals = true;
            int indexMin = 0;
            for (int i = 0; i < n; i++)
            {
                if (vehicles[i] != null)
                {
                    Console.WriteLine(vehicles[i].ToString());
                    if (vehicles[indexMin].GetTotalCosts() > vehicles[i].GetTotalCosts())
                        indexMin = i;
                    if (i > 0 && !vehicles[i].Equals(vehicles[i-1]))
                        allEquals = false;
                }
                else
                {
                    Console.WriteLine("NULL");
                    allEquals = false;
                }
            }
            Console.WriteLine("\nVehicle with minimal cost: " + vehicles[indexMin].ToString());
            Console.WriteLine("All vehicles are equal: " + allEquals.ToString());

            Console.ReadLine();
        }
    }
}
