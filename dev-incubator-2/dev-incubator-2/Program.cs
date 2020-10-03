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
        const int timeMinWait = 0;      //delay parameters before adding to the queue
        const int timeMaxWait = 2000;   //

        static void Main(string[] args)
        {
            VehicleCollection vehicleCollection = new VehicleCollection();
            for (int i = 0; i < args.Length; i++)
                vehicleCollection.AddFromFile(args[i]);

            WashVehicle wash = new WashVehicle(vehicleCollection.Vehicles.Count);
            Random random = new Random();
            foreach (AbstractVehicle vehicle in vehicleCollection.Vehicles)
            {
                Thread.Sleep(random.Next(timeMinWait, timeMaxWait)); //Time between new cars 
                wash.StartWash(vehicle);
            }

            Console.ReadLine();
        }
    }
}
