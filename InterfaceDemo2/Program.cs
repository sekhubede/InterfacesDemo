using System;
using DemoLibrary2;
using static System.Console;

namespace InterfaceDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating two objects of type chair.
            Chair officeChair = new Chair("Brown","Plastic");
            Chair gamingChair = new Chair("Red","Wood");

            // Creating a new object of type car.
            Car damagedCar = new Car(80,"Blue");

            // Add the two chairs to the IDestrotable list of the car
            // so that when we destroy the car the destroyable objects
            // that are near the car will get destroyed as well.
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();

            WriteLine("\nPress any key to exit...");
            ReadKey(true);
        }
    }
}
