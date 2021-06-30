using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public interface IPrintTasks
    {
        void PrintTask(string printContent);
        void FaxTask(string faxCotent);
        void PhotoCotyTask(string photoCopy);
    }
}
