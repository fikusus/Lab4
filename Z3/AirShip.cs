using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class AirShip : Ship
    {
        public Dictionary<string, int> planes { get; private set; }

        public AirShip(string name, double water_consumption, double engine_power, string fuel_type, Dictionary<string, int> planes):base(name,"aircraft carrier", water_consumption, engine_power, fuel_type)
        {
            this.planes = planes;
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Planes:");
            foreach (var item in planes)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
