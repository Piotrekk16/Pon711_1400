using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Bicycle : Vehicle, IRideable, IMusic
    {
        public void Ride()
        {
            Console.WriteLine("Jadę rowerem");
        }

        public void PlayMelody()
        {
            Console.WriteLine("Dryń");
        }
    }
}
