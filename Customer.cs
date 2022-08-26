using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation
{
    class Customer : CommonClass, IEnterData, IDisplay
    {
        int phoneNumber { get; set; }
        string address { get; set; }

        public void EnterData()
        {
            Console.WriteLine("Enter Customer Id Number");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Customer phoneNumber");
            phoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Address");
            address = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine($"Customer Detail: Id = {Id} Name = {Name} Phone Number ={phoneNumber} Address ={address}");
        }
    }
}
