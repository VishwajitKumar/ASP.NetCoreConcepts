using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage printMessage = new PrintMessage();
            printMessage.PrintMessageToConsole("Hello");
            printMessage.PrintToConsole();
            Console.ReadKey();
        }
    }


    public class PrintMessage
    {
        public string message = "Hi";
        public void PrintMessageToConsole(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
    public static class Extended
    {
        public static void PrintToConsole(this PrintMessage printMessage)
        {
            Console.WriteLine($"{printMessage.message}");
        }
    }
}
