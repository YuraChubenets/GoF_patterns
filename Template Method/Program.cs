using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass cc = new ConcreteClass();
            cc.TemplateMethod();

            Console.ReadLine();

        }
    }

      //Когда использовать шаблонный метод?

      //Когда планируется, что в будущем подклассы должны будут переопределять различные этапы алгоритма без изменения его структуры
      //Когда в классах, реализующим схожий алгоритм, происходит дублирование кода.Вынесение общего кода в шаблонный метод уменьшит его дублирование в подклассах.


    abstract class Template
    {
        public abstract void TemplateMethod();
    }
    abstract class AbstractClass : Template
    {
        public sealed override void TemplateMethod()
        {
            Operation1();
            Operation2();
        }
        public abstract void Operation1();
        public abstract void Operation2();
    }

    class ConcreteClass : AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine("Operation1");
        }

        public override void Operation2()
        {
            Console.WriteLine("Operation2");
        }
    }

}
