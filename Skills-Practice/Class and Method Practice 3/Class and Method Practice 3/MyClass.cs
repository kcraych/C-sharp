using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_Practice_3
{
    class MyClass
    {
        public int MathOp1(int num)
        {
            return num * num;
        }

        public decimal MathOp1(decimal num)
        {
            return num  + 2;
        }

        public int MathOp1(string str)
        {
            return Convert.ToInt32(str) * 10;
        }
    }
}
