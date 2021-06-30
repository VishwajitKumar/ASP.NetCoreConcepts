using ISP.Client;
using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            HPPrinter hPPrinter = new HPPrinter();
            hPPrinter.FaxTask("HP Printer- Fax Task");
            hPPrinter.PhotoCotyTask("HP Printer- PhotoCopy Task");
            hPPrinter.PrintTask("HP Printer- Print Task");
            hPPrinter.ScanTask("HP Printer- Scan Task");

            Xerox xerox = new Xerox();
            xerox.FaxTask("Xerox Printer- Fax Task");
            xerox.PhotoCotyTask("Xerox Printer- PhotoCopy Task");
            xerox.PrintTask("Xerox Printer- Print Task");
            Console.ReadKey();
        }
    }
}
