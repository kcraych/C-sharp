using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Practice_1
{
    public class Dog
    {
        public Dog(string name) : this(name, "Unknown")
        {
        }

        public Dog(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }

        public string Name { get; set; }
        public string Breed { get; set; }

    }
}
