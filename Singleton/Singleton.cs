using System;
using System.Collections.Generic;
using System.Text;

namespace singletonwiththreadsafety
{
    public sealed class SingletonClass
    {
        private static int Counter { get; set; } = 0;
        private SingletonClass()
        {
            Counter++;
            Console.WriteLine($"Instance count: {Counter}");
        }

        private static SingletonClass singletonClass = null;

        private static readonly object obj = new object();
        public static SingletonClass GetSingleInstance
        {
            get
            {
                //Double check locking. Lock restrict to create only one instance
                if (singletonClass == null)
                {
                    lock (obj)
                    {
                        if (singletonClass == null)
                        {
                            singletonClass = new SingletonClass();
                        }
                    }
                }
                return singletonClass;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
