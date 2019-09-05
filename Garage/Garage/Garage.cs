using System;
using System.Collections.Generic;
using System.Text;
using Garage.Base;

namespace Garage
{
    public class Garage
    {
        // Attributes
        public bool IsFull { get; set; } = false;
        public int MaxNumberOfVehicles { get; set; }
        public int CurrentNumberOfVehicles { get; set; }

        List<Vehicle> Vehicles = new List<Vehicle>();


        /// <summary>
        /// Garage Class overload on constructor
        /// </summary>
        /// <param name="maxNumberOfVehicles">int</param>
        /// <param name="currentNumberOfVehicles">int</param>
        public Garage(int maxNumberOfVehicles, int currentNumberOfVehicles)
        {
            MaxNumberOfVehicles = maxNumberOfVehicles;
            CurrentNumberOfVehicles = currentNumberOfVehicles;
        }


        /// <summary>
        /// Adds vehicle to the garage
        /// </summary>
        /// <param name="vehicle">Vehicle vehicle</param>
        public void AddCar(Vehicle vehicle)
        {

            if(CurrentNumberOfVehicles >= MaxNumberOfVehicles)
            {
                Console.WriteLine("Garage is Full!");
                IsFull = true;
            }
            else
            {
                Console.WriteLine($"One {vehicle.Make}, {vehicle.Model} parked in the garage");
                Vehicles.Add(vehicle);
                CurrentNumberOfVehicles++;
            }
        }

    
    }
}
