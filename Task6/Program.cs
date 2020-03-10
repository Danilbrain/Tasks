using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle veh = new Vehicle("veh");
            veh.Display();
            veh.Go();
            veh.Display();
            veh.Stop();
            veh.Display();

            Console.WriteLine("\n\n\n");

            Car car = new Car("car","test", 270.3f);
            car.Display();
            car.getState();
            car.changeState();
            car.getState();
        }
    }
}
