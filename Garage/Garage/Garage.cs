using System;
using System.Collections.Generic;
using System.Text;
using Garage.Base;

namespace Garage
{
    public class Garage
    {
        public bool IsFull { get; set; } = false;
        public int MaxNumberOfVehicles { get; set; }
        public int NumberOfVehicles { get; set; }

        List<Vehicle> Vehicles = new List<Vehicle>();

        public Garage()
        {
            MaxNumberOfVehicles = 2;
            NumberOfVehicles = 0;
        }

        public Garage(int maxNumberOfVehicles, int currentNumberOfVehicles)
        {
            MaxNumberOfVehicles = maxNumberOfVehicles;
            NumberOfVehicles = currentNumberOfVehicles;
        }

        public void AddCarToGarage(Vehicle vehicle)
        {

            if(MaxNumberOfVehicles >= NumberOfVehicles)
            {
                Console.WriteLine("Garage is Full!");
                IsFull = true;
            }
            else
            {
                Console.WriteLine($"One {vehicle.Make} parked in the garage");
                Vehicles.Add(vehicle);
                NumberOfVehicles++;
            }
        }

    
    }
}
