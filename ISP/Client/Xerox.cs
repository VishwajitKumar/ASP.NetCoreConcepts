using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Client
{
    public class Xerox : IPrintTasks
    {
        public Xerox()
        {

        }
        public void FaxTask(string faxCotent)
        {
            Console.WriteLine(faxCotent);
        }

        public void PhotoCotyTask(string photoCopy)
        {
            Console.WriteLine(photoCopy);
        }

        public void PrintTask(string printContent)
        {
            Console.WriteLine(printContent);
        }

        
    }
}
