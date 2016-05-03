using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Owner : INotify
    {
        internal Owner()
        { }

        public void Notify()
        {
            Console.WriteLine("Notify this owner--" + this.GetHashCode());
        }
    }
}
