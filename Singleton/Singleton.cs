using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DesignPatterns
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        private int numberofInstances = 0;

        //private constructor is used to prevent
        //creation of instances w/ 'new' keyword outside this class
        private Singleton()
        {
            WriteLine("Instantiating inside the private constructor.");
            numberofInstances++;
            WriteLine($"Number of instances = {numberofInstances}");
        }

        public static Singleton Instance
        {
            get
            {
                WriteLine("We already have an instance now.  Use it");
                return instance;
            }
        }

        public static void SingletonExample1()
        {
            WriteLine(Singleton.MyInt);
        }

        public static void SingletonExample2()
        {
            WriteLine("Singleton Patterm Demo");
            WriteLine("Trying to create instance s1.");
            Singleton s1 = Singleton.Instance;
            WriteLine("Trying to create instance s2.");
            Singleton s2 = Singleton.Instance;

            if (s1 == s2)
            {
                WriteLine("Only one instance exists.");
            }
            else
            {
                WriteLine("Difference instances exist.");
            }
        }

        public static int MyInt = 25;
    }
}
