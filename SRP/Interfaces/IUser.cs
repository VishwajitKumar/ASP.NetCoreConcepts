using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    interface IUser
    {
        bool Login(string userName, string Password);
        bool Logout(string userName);
    }
}


