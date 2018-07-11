using DesignPatterns.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Private constructor.  So, we cannot use 'new' keyword.
            //Singleton.SingletonExample1();
            //Singleton.SingletonExample2();
            PrototypeExample();

            Read();
        }

        private static void PrototypeExample()
        {
            WriteLine("Prototype Pattern Demo");
            //Base or Original Copy
            BasicCar nano_base = new Nano("Green Nano") { Price = 100000 };
            BasicCar ford_base = new Nano("Ford Yellow") { Price = 500000 };
            BasicCar bc1;

            //Nano
            bc1 = nano_base.Clone();
            bc1.Price = nano_base.Price + BasicCar.SetPrice();
            WriteLine($"Car is: {bc1.ModelName}, and it's price is Rs. {bc1.Price}");

            //Ford
            bc1 = ford_base.Clone();
            bc1.Price = ford_base.Price + BasicCar.SetPrice();
            WriteLine($"Car is: {bc1.ModelName}, and it's price is Rs. {bc1.Price}");
        }


    }
}
