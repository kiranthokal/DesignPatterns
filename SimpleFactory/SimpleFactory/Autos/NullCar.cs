﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Autos
{
    public class NullCar : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("\nNull car");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nNull car");
        }
    }
}
