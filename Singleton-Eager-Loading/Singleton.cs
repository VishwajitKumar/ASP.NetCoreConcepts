using System;
using System.Collections.Generic;
using System.Text;

namespace singleton_eager_loading
{
    public sealed class Singleton
    {
        private static int Counter { get; set; } = 0;
        public Singleton()
        {
            Counter++;
            Console.WriteLine($"Instance count: {Counter}");
        }
        ////Eager loading
        ////private static readonly Singleton instance = new Singleton();

        ////Lazy loading
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>();
        public static Singleton GetSingleton
        {
            get
            {
                return instance.Value;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
