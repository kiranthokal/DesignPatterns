using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Autos
{
    public class BMWCar : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("\nBMW turned on");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nBMW turned off");
        }
    }
}
