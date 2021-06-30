using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Interface
{
    public interface IEmail
    {
        public void SendMail(string content);
    }
}
