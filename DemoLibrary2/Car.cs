using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace DemoLibrary2
{
    // Subclass Car that extends Vehicle
    public class Car : Vehicle, IDestroyable
    {
        // Implement the interface's property.
        public string DestructionSound { get; set; }

        // Creating a new property to store the destroyable objects nearby
        // when a car gets destroyed it should also destroy the nearby object
        // this list is of type IDestroyable which means it can store any object
        // that implements this interface and we can only access the properties and
        // methods in this interface.

        public List<IDestroyable> DestroyablesNearby;

        // Simple constructor.
        public Car(float speed, string color) : base (speed, color)
        {
            // Initialize the interface's property with a value in the contructor.
            DestructionSound = "CarExplosionSound.mp3";
            // Initialize the list of destroyable objects.
            DestroyablesNearby = new List<IDestroyable>();
        }

        // Implement the inteace's method.
        public void Destroy()
        {
            // When a car gets destroyed we should play the destruction sound
            // and create fire effect.
            WriteLine($"Playing destruction sound {DestructionSound}");
            WriteLine("Create fire!");

            // Go through each destroyable object nearby adn call it's destroy method.
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
