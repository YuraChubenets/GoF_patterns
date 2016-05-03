using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;

            client = new Client(new ConcreteFactory1());
            //or
           //client = new Client(new ConcreteFactory2());

            client.Run(Show);
            Console.ReadKey();

        }

        static void Show(string message )
        {
            Console.WriteLine(message);
        }
    }

    // Когда система не должна зависеть от способа создания и компоновки новых объектов
    // Когда создаваемые объекты должны использоваться вместе и являются взаимосвязанными
    // Когда внутреннее устройство объекта и поведения настраиваются при ее создании.


    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    abstract class AbstractProductA  {}

    abstract class AbstractProductB  { }

    class ProductA1 : AbstractProductA {  }

    class ProductB1 : AbstractProductB {   }

    class ProductA2 : AbstractProductA {   }

    class ProductB2 : AbstractProductB  {    }

    class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            abstractProductB = factory.CreateProductB();
            abstractProductA = factory.CreateProductA();

        }
        public void Run(Action<string> message)
        {
            message(string.Format(abstractProductB.GetType().Name + " " + abstractProductA.GetType().Name));
                   
        }
    }    
}
