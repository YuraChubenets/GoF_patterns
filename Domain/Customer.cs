using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Customer : INotify
    {
        internal Customer()
        {        }

        public void Notify()
        {
            Console.WriteLine("Notify this " +nameof(Customer)+" "+this.GetHashCode());
        }
    }
}
