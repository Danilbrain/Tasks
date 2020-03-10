using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Truck : Car, ITrailer
    {
        public int LoadCapability { get; set; }
        private bool tHook;
        private int tWeight;
        public Truck(string name, string _man, int loadCap) : base(name, _man)
        {
            LoadCapability = loadCap;
        }

        public void hook(int _tWeight)
        {
                tHook = true;
            tWeight = _tWeight;
                Console.WriteLine("Trailer hooked!");
        }

        public override void Go()
        {
            if(tWeight<=LoadCapability)
            base.Go();
            else
                Console.WriteLine("Overload!");
        }

        public void unhook()
        {
            tHook = false;
            tWeight = 0;
        }


    }
}
