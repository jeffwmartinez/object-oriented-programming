using Garage.Concrete;
using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {

            int speed = 20;

            Console.WriteLine();
            Console.WriteLine("Encapsulation");
            ModelX modelx = new ModelX();
            Console.WriteLine($"{modelx.IsSuv}, ModelX class is instantiated");
            Console.WriteLine();
            Console.WriteLine("Inheritance");
            modelx.Accelerate(speed);
            Console.WriteLine();
            Console.WriteLine("Abstraction");
            modelx.OpenFalconWingDoors();
            Console.WriteLine();
            Console.WriteLine("Polymorphism");
            modelx.RegistrationFees();
        }
    }
}
