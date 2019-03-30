using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_Practice_4
{
    class MyClass
    {
        public int MyMethod(int num1, int num2 = 0)
        {
            return num1 + 10 * num2;
        }
    }
}
