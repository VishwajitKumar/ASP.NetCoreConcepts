using LSP.Interface;
using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new PermanentEmp { Id = 1, Name = "John" };
            Employee employee2 = new ContractEmp { Id = 2, Name = "Peter" };
            IEmployee employee3 = new TemporaryEmployee { Id = 2, Name = "Dev" };

            double johnSal = employee1.CalculateBonus(10000);
            double DavidSal = employee2.CalculateBonus(10000);
            double DevSal = employee3.GetMinimumSalary(5000);

            Console.WriteLine("Id:{0} Name:{1}, Salary:{2}", employee1.Id, employee1.Name, johnSal);
            Console.WriteLine("Id:{0} Name:{1}, Salary:{2}", employee2.Id, employee2.Name, DavidSal);
            Console.WriteLine("Id:{0} Name:{1}, Salary:{2}", employee3.Id, employee3.Name, DevSal);
            Console.ReadKey();
        }
    }
}
