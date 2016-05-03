using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var john = EmployeeFactory.NewMainEmployee("John", 1000);
            var jill = EmployeeFactory.NewMainEmployee("Jill", 100);
            var bob = EmployeeFactory.NewMainEmployee("Robert", 123);


            Console.WriteLine(jill);
            Console.WriteLine(john);
            Console.WriteLine(bob);

            Console.ReadKey();

        }
    }


    class EmployeeFactory
    {
      private  static Contact main = new Contact { WorkAddress = new Address { City = "London", Street = "221B Baker str" } };
      private static Contact aux = new Contact { WorkAddress = new Address { City = "Bern", Street = "221B Gorn str" } };

        public static Contact NewAuxEmployee(string name, int suite)
        {
            return NewEmployee(name, suite, main);
        }

        public static Contact NewMainEmployee(string name, int suite)
        {
            return NewEmployee(name, suite, aux);
        }
        
        public  static Contact NewEmployee(string name, int suite , Contact proto)
        {
           var result = main.DeepCopy();
           result.Name = name;
           result.WorkAddress.Suite = suite;
            return result;
        }
    }

    [Serializable]
    public class Contact
    {
        public string Name;
        public Address WorkAddress;

        public override string ToString()
        {
            return $"Name: {Name} , WorkAddress: { WorkAddress }";
        }
    }


    [Serializable]
    public class Address
    {
        public string Street;
        public string City;
        public int Suite;


        public override string ToString()
        {
            return $"Street: {Street}, City: {City}, Suite: { Suite}";
        }
    }


   static class ExtMethod
    {
        public static T DeepCopy<T>(this T self)
        {
            if(!typeof(T).IsSerializable)
            {
                throw new ArgumentException("type most be serializable");
            }
            if (ReferenceEquals(self, null))
                return default(T);
            var formatter = new BinaryFormatter();


            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
    }

}
