using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Computing
    {
        public string OddOrEven(int value)
        {
            return value % 2 == 0 ? "Even" : "Odd";
        }
    }
}
