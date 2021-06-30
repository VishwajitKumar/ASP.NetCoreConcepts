using System;
using System.Collections;

namespace TestCheckProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit type variable can not be declare more than one variable at a time.
            //var i = 10, j = 20, k = 30;

            //it will print blank
            //IList list = null;
            //Console.WriteLine(list?[0]);

            //it will print 16
            //int sixteen = 0b0001_0000;
            //Console.WriteLine(sixteen);

            // it will print 50
            //Action<int> DoSomething = i => Console.WriteLine(i);
            //DoSomething(50);

            var input = "100";
            if(int.TryParse(input,out int result))
            {
                Console.WriteLine(result);
                Console.WriteLine(sizeof(int));
            }
            else
            {
                Console.WriteLine("could not parse value");
            }

            Console.ReadKey();
        }
    }
}
