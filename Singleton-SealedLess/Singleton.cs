using System;
using System.Collections.Generic;
using System.Text;

namespace singleton_sealedless
{
    public class Singleton
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

        public class DerivedSingleton : Singleton
        {
        }
    }
}
