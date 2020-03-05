using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship =   new Ship("Plot", "plavatel", 52000, 4000, "benzin");
            ship.PrintInfo();
            AirShip airShip = new AirShip("Samolet", 100000, 10000, "gaz", new Dictionary<string, int> { { "TU-4",5},{"Stels",8} });
            airShip.PrintInfo();

            RocketShip rocketShip = new RocketShip("Raketa - 1", 542500, 2807520, "BioFuel", new Dictionary<string, int> { { "NB-104", 100 }, { "ZN-69", 44 } });
            rocketShip.PrintInfo();

            Console.ReadKey();
        }
    }
}
