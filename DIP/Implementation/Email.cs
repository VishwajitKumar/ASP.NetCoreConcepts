using DIP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Implementation
{
    public class Email : IEmail
    {
        public void SendMail(string content)
        {
            Console.WriteLine(content);
        }
    }
}
