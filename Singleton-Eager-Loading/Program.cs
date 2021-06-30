using System;
using System.Threading.Tasks;

namespace singleton_eager_loading
{
    class Program
    {
        protected Program()
        {

        }
        static void Main(string[] args)
        {
            Parallel.Invoke(() => Instance1(), () => Instance2());

            Console.ReadKey();

        }

        public static void Instance1()
        {
            Singleton singleton1 = Singleton.GetSingleton;
            singleton1.PrintMessage("Hi From instance 1");
        }
        public static void Instance2()
        {
            Singleton singleton2 = Singleton.GetSingleton;
            singleton2.PrintMessage("Hi From instance 2");
        }
    }
}
