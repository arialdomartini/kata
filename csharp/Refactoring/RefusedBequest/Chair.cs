using System;

namespace Kata.Refactoring.RefusedBequest
{
    class Legs
    {
        public string Leg1{ get; set; }
        public string Leg2{ get; set; }
        public string Leg3{ get; set; }
        public string Leg4{ get; set; }
    }

    class Chair : Legs
    {
        public void Sit()
        {
            Console.WriteLine("Sit on " + Leg1 + Leg2 + Leg3 + Leg4);
        }
    }

    class Dog : Chair
    {
        public void Bark()
        {
            Console.WriteLine("Bark on " + Leg3 + Leg4);

            // it doesn't use Chair.Sit().
            // It's the sign it shoudln't inherit from Chair
        }
    }
}