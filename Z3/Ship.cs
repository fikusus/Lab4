using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class Ship
    {
        public string name { get; private set; }
        public string purpose { get; private set; }
        public double water_consumption { get; private set; }
        public double engine_power{ get; private set; }
        public string fuel_type { get; private set; }

        public Ship(string name, string purpose, double water_consumption, double engine_power, string fuel_type)
        {
            this.name = name;
            this.purpose = purpose;
            this.water_consumption = water_consumption;
            this.engine_power = engine_power;
            this.fuel_type = fuel_type;
        }

        public void PrintInfo() {         
            Console.WriteLine("\n" + this.GetType());
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Purpose: " + purpose);
            Console.WriteLine("Water consumption: " + water_consumption);
            Console.WriteLine("Engine power: " + engine_power);
            Console.WriteLine("Type of fuel: " + fuel_type);
        }
    }
}
