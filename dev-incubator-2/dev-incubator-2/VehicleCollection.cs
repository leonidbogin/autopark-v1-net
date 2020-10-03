using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class VehicleCollection : VehicleSurcharge
    {
        public List<AbstractVehicle> Vehicles { get; }

        public VehicleCollection() 
        {
            Vehicles = new List<AbstractVehicle>();
        }

        public VehicleCollection(string inFile) 
        {
            Vehicles = new List<AbstractVehicle>();
            AddFromFile(inFile);
        }

        public void AddFromFile(string inFile)
        {
            try
            {
                StreamReader sr = new StreamReader(inFile + ".csv");
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Vehicles.Add(CreateVehicle(s));
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File {inFile} not found.");
            }
        }

        private AbstractVehicle CreateVehicle(string csvString)
        {
            string[] split = csvString.Split(',','\n');
            decimal surchargeKilometer = 0;
            if (split.Length > 3) surchargeKilometer = ParseDecimal(split[3]);
            return new VehicleSurcharge(split[0], ParseDecimal(split[1]), ParseDecimal(split[2]), surchargeKilometer);
        }

        private static decimal ParseDecimal(string s)
        {
            return decimal.Parse(s, CultureInfo.InvariantCulture);
        }


        public void Insert(int index, AbstractVehicle vehicle)
        {
            if (index > Vehicles.Count) 
                index = Vehicles.Count;
            Vehicles.Insert(index, vehicle);
        }

        public int Delete(int index)
        {
            if (0 <= index && index < Vehicles.Count)
            {
                Vehicles.RemoveAt(index);
                return index;
            }
            else return -1;
        }

        public decimal TotalCosts()
        {
            decimal sumCosts = 0;
            foreach (AbstractVehicle vehicle in Vehicles)
                sumCosts += vehicle.GetTotalCosts();
            return sumCosts;
        }

        public void Print()
        {
            Console.WriteLine(TabString("    Name","Cost ","Km/month ","Other cost ","Total "));
            foreach (AbstractVehicle vehicle in Vehicles)
            {
                string addCost = string.Empty;
                if (vehicle is VehicleSurcharge)
                {
                    VehicleSurcharge vehicleSurcharge = (VehicleSurcharge)vehicle;
                    if (vehicleSurcharge.SurchargeKilometer != 0)
                        addCost = vehicleSurcharge.SurchargeKilometer.ToString();
                }

                Console.WriteLine(TabString(
                        vehicle.VehicleCosts.Name, 
                        vehicle.VehicleCosts.AverageCostKilometer, 
                        vehicle.AverageKilometers, 
                        addCost, 
                        vehicle.GetTotalCosts()));
            }
            Console.WriteLine(TabString("Total cost","","","",TotalCosts()));
            Console.WriteLine();
        }

        public static string TabString(params object[] str)
        {
            if (str.Length > 0)
            {
                string output = string.Format("\t{0,-14}", str[0].ToString());
                for (int i = 1; i < str.Length; i++)
                    output += string.Format("{0,15}", str[i].ToString());
                return output;
            }
            else return null;
        }

        public void Sort(IComparer<AbstractVehicle> comparator)
        {
            Vehicles.Sort(comparator);
        }   
    }
}
