using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary2
{
    // Base class for Vehicles.
    public class Vehicle
    {
        // Speed of the vehicle.
        public float Speed { get; set; }

        // Color of the vehicle.
        public string Color { get; set; }

        // Default constructor.
        public Vehicle()
        {
            Speed = 120f;
            Color = "White";
        }

        // Simple constructor.
        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
