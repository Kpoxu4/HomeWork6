using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public abstract class Animals
    {
        protected string Name { get; set; }

        protected Animals(string name)
        {
            Name = name;    
        } 

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} Животное есть");
        }
        public virtual void Voice() 
        {
            Console.WriteLine($"{Name} выдает звуки");
        }

    }
}
