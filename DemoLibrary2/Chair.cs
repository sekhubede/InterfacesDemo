using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary2
{
    // Subclass chair that extends Furniture.
    public class Chair : Furniture
    {
        // Simple constructor.
        public Chair (string color, string material) : base (color, material) 
        { 
         
        }
    }
}
