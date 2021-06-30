using DIP.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Implementation
{
    public class Chore : IChore
    {
        public string ChoreName { get; private set; }
        public double HoursWorked { get; private set; }
       
        public Chore()
        {
            
        }
        public void HourPerformed(double hrs)
        {
            Console.WriteLine($"{hrs} hrs chores completed.");
        }

        public void CompleteChore()
        {
            Console.WriteLine("Chores completed.");
        }
    }
}
