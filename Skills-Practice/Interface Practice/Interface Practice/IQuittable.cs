using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
    interface IQuittable
    {
        void Quit();
        //CLARIFYING QUESTION:
        //I thought I might want to make the input be (Employee employee) since I would only want the Quit method to be used on an Employee object, but I ran into trouble
        //with this when trying to implement the Quit method in the Employee class.  Should I be including this input, and if so, how should I handle it on the Employee class file?
        //Or, is it better to leave it without inputs, and if so, how come?
    }
}
