using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_IObserver_
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer c = new CustomerManager().CreateCustomer();        
            Console.WriteLine(c.ToString());

            new CustomerManager().CreateOwner();
            new CustomerManager().CreateOwner();
            new CustomerManager().CreateOwner();

            new CustomerManager().CreateCustomer();
            new CustomerManager().CreateCustomer();
            new CustomerManager().CreateCustomer();

            Console.ReadKey();

            Storage.Instance.AddProduct();          

            Console.ReadKey();
            Console.WriteLine("--end--");
            Console.ReadKey();
        }
    }
    
}
