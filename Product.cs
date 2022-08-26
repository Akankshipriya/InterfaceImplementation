using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation
{
    class Product : CommonClass, IEnterData, IDisplay
    {
        string category { get; set; }
        int price { get; set; }

        public void EnterData()
        {
            Console.WriteLine("Enter Product Id Number");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Product category");
            category = Console.ReadLine();
            Console.WriteLine("Enter Product price");
        }

        public void Display()
        {
            Console.WriteLine($"Product Detail: Id = {Id} Name = {Name} Category ={category} Price={price}");
        }
    }
}
