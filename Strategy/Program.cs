using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Context ctx = new Context(new ConcreteStrategy1());
            //or
            // Context ctx = new Context(new ConcreteStrategy2());
            ctx.ExecuteAlgorithm(Show);

            Console.ReadLine();
        }

        static void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
    //Когда использовать стратегию?

    //Когда есть несколько родственных классов, которые отличаются поведением.Можно задать один основной класс, а разные варианты поведения вынести в отдельные классы и при необходимости их применять
    //Когда необходимо обеспечить выбор из нескольких вариантов алгоритмов, которые можно легко менять в зависимости от условий
    //Когда необходимо менять поведение объектов на стадии выполнения программы
    //Когда класс, применяющий определенную функциональность, ничего не должен знать о ее реализации

    public interface IStrategy
    {
        void Algorithm(Action<string> message);
    }

    public class ConcreteStrategy1 : IStrategy
    {
        public void Algorithm(Action<string> message)
        {
            message(string.Format(this.GetType().Name));
        }
    }

    public class ConcreteStrategy2 : IStrategy
    {
        public void Algorithm(Action<string> message)
        {
            message(string.Format(this.GetType().Name));
        }
    }

    public class Context
    {
        public IStrategy ContextStrategy { get; set; }

        public Context(IStrategy _strategy)
        {
            ContextStrategy = _strategy;
        }

        public void ExecuteAlgorithm(Action<string> print)
        {
            ContextStrategy.Algorithm(print);
        }
    }

}
