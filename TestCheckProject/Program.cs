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

        public int PrintVal(ref int i)
        {
            i = 10;
            return i;
        }
        //Can not overload method based on ref and out keyword
        //public int PrintVal(out int i)
        //{
        //    i = 10;
        //    return i;
        //}
    }

    class A
    {
        public virtual void display()
        {
            Console.WriteLine("A - display");
        }
        public virtual void disp()
        {
            Console.WriteLine("A - disp");
        }
    }
    abstract class ab : A
    {
        public ab()
        { }
        public abstract override void display(); //Error Line 1

        public sealed override void disp()  //Error Line 2
        {
            Console.WriteLine("disp is sealed now.");
        }
}
}
