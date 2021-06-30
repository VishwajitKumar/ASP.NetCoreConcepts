using DIP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Implementation
{
    class Logger : ILogger
    {
        public void Log(string logText)
        {
            Console.WriteLine(logText);
        }
    }
}
