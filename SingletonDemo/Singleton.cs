using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    //private constructor restrict the inheritance of the class. but
    //If we will not make the class sealed the nested class can inherite the class despite of private constructor and create new instance for each initialization.
    //public sealed class Singleton
    public sealed class Singleton
    {
        private static int Counter { get; set; } = 0;

        private static Singleton instance = null;

        private Singleton()
        {
            Counter++;
            Console.WriteLine($"Instance count:{Counter}");
        }
        public static Singleton GetSingleInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
