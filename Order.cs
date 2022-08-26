using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation
{
    class Order : CommonClass, IEnterData, IDisplay
    {
        int trackingNo { get; set; }
        string shipmentAddress { get; set; }

        public void EnterData()
        {
            Console.WriteLine("Enter Order Id Number");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Order TrackingNo");
            trackingNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Shipment Address");
            shipmentAddress = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine($"Order Detail: Id = {Id} Name = {Name} TrackingNo ={trackingNo} Shipment Address={shipmentAddress}");
        }
    }
}
