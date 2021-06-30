using DIP.Interface;
using System;

namespace DIP
{
    class Program : DIP.Factory.Factory
    {
        static void Main(string[] args)
        {
            IPerson person = Factory.Factory.GetPerson();
            person.Name = "John";

            IChore chore = Factory.Factory.GetChore();
            
            ILogger logger = Factory.Factory.GetLogger();
            
            IEmail email = Factory.Factory.GetTexter();

            chore.HourPerformed(10);
            chore.CompleteChore();
            logger.Log("Completed");
            email.SendMail($"Hi {person.Name}, chore is completed");
            Console.ReadKey();
        }
    }
}
