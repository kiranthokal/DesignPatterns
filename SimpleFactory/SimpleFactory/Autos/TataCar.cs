using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Autos
{
    public class TataCar : IAuto
    {
        public void TurnOff()
        {
            Console.WriteLine("\nTataCar turned on");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nTataCar turned off");
        }
    }
}
