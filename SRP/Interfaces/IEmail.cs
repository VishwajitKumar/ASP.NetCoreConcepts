using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple.Interfaces
{
    interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}

