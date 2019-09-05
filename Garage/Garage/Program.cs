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
            ModelX modelx = new ModelX()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Model X",
                NumberOfWheels = 4,
                IsSuv = true,
                IsElectric = true
            };
                

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

            Console.WriteLine();
            Console.WriteLine("Garage");
            Garage garage = new Garage(2, 0);

            garage.AddCar(modelx);
            garage.AddCar(modelx);
            garage.AddCar(modelx);
        }
    }
}
