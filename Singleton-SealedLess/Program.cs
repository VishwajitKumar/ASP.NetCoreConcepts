using System;

namespace singleton_sealedless
{
    class Program
    {
        protected Program()
        {

        }
        static void Main(string[] args)
        {
            Singleton BEmpSingleton = Singleton.GetSingleInstance;
            BEmpSingleton.PrintMessage("Message from BEmpinstance");

            Singleton BStudSingleton = Singleton.GetSingleInstance;
            BStudSingleton.PrintMessage("Message from BStudinstance");

            Console.WriteLine("-----------------------------------------");
            Singleton.DerivedSingleton EmpSingleton = new Singleton.DerivedSingleton();
            EmpSingleton.PrintMessage("Message from Empinstance");

            Singleton.DerivedSingleton StudSingleton = new Singleton.DerivedSingleton();
            StudSingleton.PrintMessage("Message from Studinstance");

            Console.ReadKey();
        }
    }
}
