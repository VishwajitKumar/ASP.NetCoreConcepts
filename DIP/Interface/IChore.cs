using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.Interface
{
    public interface IChore
    {
        public void HourPerformed(double hrs);
        public void CompleteChore();
    }
}
