using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            Creator creator = new ConcreteCreatorA();

            Product prod = creator.FactoryMethod();
            Console.WriteLine(prod.GetType());
            Console.ReadKey();

        }
    }

    abstract class Product
    { }

    class ConcreteProductA : Product
    { }

    class ConcreteProductB : Product
    { }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductA(); }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductB(); }
    }
}
