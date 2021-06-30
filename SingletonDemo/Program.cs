using System;

namespace SingletonDemo
{
    class Program
    {
        protected Program()
        {

        }
        static void Main(string[] args)
        {
           Singleton EmpSingleton= Singleton.GetSingleInstance;
            EmpSingleton.PrintMessage("Message from Empinstance");

            Singleton StudSingleton = Singleton.GetSingleInstance;
            StudSingleton.PrintMessage("Message from Studinstance");

            Console.ReadKey();
        }
    }
}
