using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Interface
{
    interface IEmployee
    {
       public int Id { get; set; }
        public string Name { get; set; }
        double GetMinimumSalary(double salary);
    }
}
