using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary2
{
    // Base class for furnitures.
    public class Furniture
    {
        // Color of the furniture.
        public string Color { get; set; }

        // Material of the furniture.
        public string Material { get; set; }

        // Default constructor.
        public Furniture() 
        {
            Color = "White";
            Material = "Wood";
        }

        // Simple constructor.
        public Furniture(string color, string matrial)
        {
            Color = color;
            Material = matrial;
        }
    }
}
