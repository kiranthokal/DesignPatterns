﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Autos
{   
    public class MiniCooper : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("\nMiniCooper turned on");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nMiniCooper turned off");
        }
    }
}
