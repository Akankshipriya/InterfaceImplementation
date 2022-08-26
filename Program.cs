using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice\n1 for Customer\n2 for Product\n3 for Order");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Customer c = new Customer();
                    c.EnterData();
                    c.Display();
                    Console.ReadLine();
                    break;
                case 2:
                    Product p = new Product();
                    p.EnterData();
                    p.Display();
                    Console.ReadLine();
                    break;
                case 3:
                    Order o = new Order();
                    o.EnterData();
                    o.Display();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please Choose a Valid input !!!");
                    break;
            }
        }
    }
}
