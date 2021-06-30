using InterfaceSegrigationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Client
{
    class HPPrinter : IPrintTasks, IScanTask, ILaminateTask
    {
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

        public void ScanTask(string scanContent)
        {
            Console.WriteLine(scanContent);
        }

        public void LaminateTask(string laminateContent)
        {
            Console.WriteLine(laminateContent);
        }
    }
}
