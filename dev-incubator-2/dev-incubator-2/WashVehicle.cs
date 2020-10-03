using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class WashVehicle
    {
        private Queue<AbstractVehicle> queueWash;
        private Thread threadWash;
        const int timeMinWash = 600;
        const int timeMaxWash = 2000;
        private int countWash = 0;
        private int sizePark = 0;

        public WashVehicle()
        {
            queueWash = new Queue<AbstractVehicle>();
        }

        public WashVehicle(int sizePark)
        {
            this.sizePark = sizePark;
            queueWash = new Queue<AbstractVehicle>();
        }

        public void StartWash(AbstractVehicle vehicle)
        {
            queueWash.Enqueue(vehicle);
            Console.WriteLine($"[Queue: {queueWash.Count}] Start wait: " + vehicle.ToString());

            if (threadWash == null || !threadWash.IsAlive)
            {
                threadWash = new Thread(new ThreadStart(Wash));
                threadWash.Start();
            }
        }

        private void Wash()
        {
            Random random = new Random();
            while (queueWash.Count > 0)
            {
                Thread.Sleep(random.Next(timeMinWash, timeMaxWash));
                Console.WriteLine($"[Queue: {queueWash.Count-1}]   Wash({++countWash}): " 
                    + queueWash.Dequeue().ToString());
            }
            if (countWash == sizePark && sizePark > 0) Console.WriteLine("Сar Park was washed!");
        }
    }
}
