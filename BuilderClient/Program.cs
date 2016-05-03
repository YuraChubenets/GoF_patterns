using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new ConcreteBuilder();
            //class creator decides how to be built
            Director director = new Director(builder);
            director.Construct();
            //Get product
            Product product = builder.GetResult();
                                    
            Console.ReadLine();
        }
    }

    //Когда использовать паттерн Строитель?

    //Когда процесс создания нового объекта не должен зависеть от того, из каких частей этот объект состоит и как эти части связаны между собой.
    //Когда необходимо обеспечить получение различных вариаций объекта в процессе его создания

    class Director
    {
        Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.BuildPartB();
            builder.BuildPartA();           
            builder.BuildPartC();
        }
    }

    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public abstract Product GetResult();
    }

    class Product
    {
        List<object> parts = new List<object>();
        public void Add(string part)
        {
            parts.Add(part);
        }
    }

    class ConcreteBuilder : Builder
    {
        Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("Part A");
            Console.WriteLine(nameof(BuildPartA));
        }
        public override void BuildPartB()
        {
            product.Add("Part B");
            Console.WriteLine(nameof(BuildPartB));

        }
        public override void BuildPartC()
        {
            product.Add("Part C");
            Console.WriteLine(nameof(BuildPartC));
        }
        public override Product GetResult()
        {
            Console.WriteLine(nameof(GetResult));
            return product;
            
        }
    }
}
