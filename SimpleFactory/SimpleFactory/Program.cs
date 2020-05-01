using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //string carName = args[0];
            string carName =Console.ReadLine();
            var carFactory = new AutoFactory();

            var car = carFactory.CreateInstance(carName);
            car.TurnOn();
            car.TurnOff();

            Console.ReadLine();
        }
    }
}

