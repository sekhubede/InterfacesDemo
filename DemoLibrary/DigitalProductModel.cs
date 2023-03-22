using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace DemoLibrary
{
    public class DigitalProductModel
    {
        public string Title { get; set; }

        public void ShipItem(CustomerModel customer)
        {
            WriteLine($"Simulating emailing {Title} to {customer.EmailAddress}");
        }
    }
}
