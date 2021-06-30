using System;

namespace val_ref_out
{
    class Program
    {
        protected Program()
        {

        }
        static void Main(string[] args)
        {
            int a = 10;
            ////Must not be defined to pass as out parameter
            ////int x;
            ValTypeParam(a);
            Console.WriteLine(a);
            RefTypeParam(ref a);
            Console.WriteLine(a);

            string nonint = "10";


            if (int.TryParse(nonint, out int y))
                OutTypeParam(out y);
            ////Can be print the value of passed out parameter 
            Console.WriteLine(y);
            Console.ReadKey();
        }

        public static int ValTypeParam(int x)
        {
            x = 20;
            return x;
        }

        public static int RefTypeParam(ref int x)
        {
            x = 20;
            return x;
        }

        public static int OutTypeParam(out int x)
        {
            //must be assigned some value to the out parameter

            x = 20;
            return x;
        }
    }
}
