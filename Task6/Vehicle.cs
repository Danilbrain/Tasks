using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Vehicle : IMove
    {
        protected bool inMove;
        public string Name { get; set; }

        public Vehicle(string name)
        {
            Name = name;
        }


        public virtual void Go()
        {
            inMove = true;
            Console.WriteLine("Started moving...");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Stopping...");
            inMove = false;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}\nIn Move: {inMove}");
        }
    }
}
