using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
    public class Employee : Person, IQuittable
    {
        public Employee()
        {
            isActive = true;
        }

        public bool isActive { get; set; }

        public void Quit()
        {
            isActive = false;
        }
    }
}