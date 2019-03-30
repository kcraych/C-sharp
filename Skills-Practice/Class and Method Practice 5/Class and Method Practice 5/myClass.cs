using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_Practice_5
{
    class myClass
    {
        public void myMethod(int num, out int result)
        {
            result = num / 2;
        }

        public static int myMethod(int num)
        {
            return num / 2;
        }
    }
}
