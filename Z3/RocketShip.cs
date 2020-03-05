using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class RocketShip:Ship
    {
        public Dictionary<string, int> rockets { get; private set; }

        public RocketShip(string name, double water_consumption, double engine_power, string fuel_type, Dictionary<string, int> rockets) : base(name, "missile carrier", water_consumption, engine_power, fuel_type)
        {
            this.rockets = rockets;
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Rockets:");
            foreach (var item in rockets)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
