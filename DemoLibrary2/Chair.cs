using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace DemoLibrary2
{
    // Subclass chair that extends Furniture.
    public class Chair : Furniture, IDestroyable
    {
        // Implement the interface's property.
        public string DestructionSound { get; set; }

        // Simple constructor.
        public Chair (string color, string material) : base (color, material) 
        {
            // Initialize the interface's property with a value in the contructor.
            DestructionSound = "ChairExplosionSound.mp3";
        }

        // Implement the inteace's method.
        public void Destroy()
        {
            // When a chair gets destroyed we should play the destrction sound
            // and spawn the destryed chair parts.
            WriteLine($"The {Color} chair was destroyed");
            WriteLine($"Playing destruction sound {DestructionSound}");
            WriteLine("Spawning chair parts!");
        }
    }
}
