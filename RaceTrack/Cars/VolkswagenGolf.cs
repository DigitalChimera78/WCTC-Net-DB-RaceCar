using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class VolkswagenGolf : RaceCar
    {
        public VolkswagenGolf() 
        {
            Name = "Volkswagen Golf";
            TopSpeed = 100;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} revs to life!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} screeches to a halt!");
            base.Brake();
        }
    }
}
