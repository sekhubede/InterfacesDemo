using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using DemoLibrary;

using static System.Console;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);

                if (prod is IDigitalProductModel digital)
                {
                    WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads.");
                }
            }

            ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Michael",
                LastName = "Sekhubede",
                City = "Windhoek",
                EmailAddress = "msekhubede@gmail.com",
                PhoneNumber = "355-4593"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Nerf Football"});
            output.Add(new PhysicalProductModel { Title = "NamDev T-Shirt"});
            output.Add(new PhysicalProductModel { Title = "Hard Drive"});
            output.Add(new DigitalProductModel { Title = "Lesson Source Code"});

            return output;
        }
    }
}
