using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public class GarageStack
    {
        private Stack<AbstractVehicle> stack;

        public GarageStack()
        {
            stack = new Stack<AbstractVehicle>();
        }

        public void Input(AbstractVehicle vehicle)
        {
            stack.Push(vehicle);
        }

        public AbstractVehicle Output()
        {
            return stack.Pop();
        }

        public int Count()
        {
            return stack.Count();
        }
    }
}
