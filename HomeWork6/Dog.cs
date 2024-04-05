using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork6
{
    internal class Dog : Animals
    {
        public Dog(string name) : base(name)
        {

        }
        public override void Eat()
        {
            Console.WriteLine($"Собака по кличке {Name} ест");
        }

        public override void Voice()
        {
            Console.WriteLine("Гав");
        }
    }
}
