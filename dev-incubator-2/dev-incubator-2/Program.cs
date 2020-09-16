﻿using System;
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

            Vehicle[] vehicles = new Vehicle[5];
            vehicles[0] = new Vehicle("МАЗ 5551", 4.5, 300, YearsOperation.Y2018);
            vehicles[1] = new Vehicle("МАЗ 5516", 4, 400, YearsOperation.Y2019);
            vehicles[2] = new Vehicle("Volkswagen Passat B5", 0.6, 800, YearsOperation.Operation);
            vehicles[3] = new Vehicle("Volkswagen Polo", 0.4, 400, YearsOperation.Y2020);
            vehicles[4] = new Vehicle("МАЗ 216", 2.8, 1200, YearsOperation.Operation);

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle != null) Console.WriteLine(vehicle.ToString());
                else Console.WriteLine("NULL");
            }

            double averageCost = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle != null)
                    averageCost += vehicle.averageCostKilometer;
            }
            averageCost = averageCost / n;
            Console.WriteLine($"\nAverage cost = {averageCost}");

            int indexMax = -1;
            for (int i = 0; i < n; i++)
                if (vehicles[i].endOperation != YearsOperation.Operation)
                    if (indexMax < 0 || vehicles[indexMax].averageCostKilometer < vehicles[i].averageCostKilometer)
                        indexMax = i;
            if (indexMax > -1) 
                Console.WriteLine($"Decommissioning year with maximum cost = {(int)vehicles[indexMax].endOperation}\n");
            else
                Console.WriteLine($"Decommissioning year with maximum cost not found\n");       

            Array.Sort(vehicles);

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle != null) Console.WriteLine(vehicle.ToString());
                else Console.WriteLine("NULL");
            }

            Console.ReadLine();
        }
    }
}
