using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Car : Vehicle , IEngine
    {
        public string Manufactor { get; set; }
        public Car(string name, string _man)
        : base(name)
        {
            Manufactor = _man;
        }
        public bool Engine;
        public void getState()
        {
            if (Engine)
                Console.WriteLine("Engine: on");
            else
                Console.WriteLine("Engine: off");
        }
        public void changeState()
        {
            Engine = !Engine;
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}\nIn Move: {inMove}");
        }
        //\nManufactor: {Manufactor}\nPrice: {Price}$\n
        public override void Go()
        {
            inMove = true;
            Console.WriteLine("Started moving...");
        }
        public override void Stop()
        {
            Console.WriteLine("Stopping...");
            inMove = false;
        }



    }
}
