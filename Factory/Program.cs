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

    // Когда заранее неизвестно, объекты каких типов необходимо создавать.
    // Когда система должна быть независимой от процесса создания новых объектов и расширяемой: в нее можно легко вводить новые классы, объекты которых система должна создавать.
    // Когда создание новых объектов необходимо делегировать из базового класса классам наследника.


    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    abstract class Product
    { }

    class ConcreteProductA : Product
    { }

    class ConcreteProductB : Product
    { }

    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductA(); }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductB(); }
    }
}
