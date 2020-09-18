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
        const int timeMinWait = 0;
        const int timeMaxWait = 4000;

        static void Main(string[] args)
        {
            VehicleCollection vehicleCollection = new VehicleCollection();
            for (int i = 0; i < args.Length; i++)
                vehicleCollection.AddFromFile(args[i]);

            WashVehicle wash = new WashVehicle(vehicleCollection.vehicles.Count);
            Random random = new Random();
            foreach (AbstractVehicle vehicle in vehicleCollection.vehicles)
            {
                Thread.Sleep(random.Next(timeMinWait, timeMaxWait)); //Time between new cars 
                wash.StartWash(vehicle);
            }

            Console.ReadLine();
        }


        private static void DisplayVehicles(AbstractVehicle[] vehicles) 
        {
            foreach (AbstractVehicle vehicle in vehicles)
                Console.WriteLine(vehicle.ToString());
        }
    }
}
