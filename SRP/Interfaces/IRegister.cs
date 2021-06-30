using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple.Interfaces
{
    interface IRegister
    {
        bool Register(string userName, string Password, string email);
    }
}
