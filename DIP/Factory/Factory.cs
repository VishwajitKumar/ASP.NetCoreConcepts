using DIP.Implementation;
using DIP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Factory
{
    public abstract class Factory
    {
        protected Factory()
        {

        }
        public static IPerson GetPerson()
        {
            return new Person();
        }

        public static IChore GetChore()
        {
            return new Chore();
        }

        public static ILogger GetLogger()
        {
            return new Logger();
        }

        public static IEmail GetTexter()
        {
            return new Email();
        }
    }
}
