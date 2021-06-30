using singletonwiththreadsafety;
using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        protected Program()
        {

        }
        static void Main(string[] args)
        {
            Parallel.Invoke(()=> EmpMethod(),()=>StudMethod());
            Console.ReadKey();
        }

        private static void StudMethod()
        {
            SingletonClass StudSingleton = SingletonClass.GetSingleInstance;
            StudSingleton.PrintMessage("Message from Studinstance");
        }

        private static void EmpMethod()
        {
            SingletonClass EmpSingleton = SingletonClass.GetSingleInstance;
            EmpSingleton.PrintMessage("Message from Empinstance");
        }

        
    }

}
