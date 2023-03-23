using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary2
{
    // Subclass Car that extends Vehicle
    public class Car : Vehicle
    {
        // Simple constructor.
        public Car(float speed, string color) : base (speed, color)
        {

        }
    }
}
