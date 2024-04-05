using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public class Cat : Animals
    {
        public Cat(string name) : base(name)
        {

        }
        public override void Eat() 
        {
            Console.WriteLine($"Кошка по кличке {Name} ест");
        }

        public override void Voice()
        {
            Console.WriteLine("Мяу");
        }
    }
}
