using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    class Product
    {
        public string name { get; private set; }
        public DateTime data { get; private set; }
        public double cost { get; private set; }
        public double dimensions { get; private set; }

        public void print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Date: " + data);
            Console.WriteLine("Cost: " + cost);
            Console.WriteLine("Dimensions: " + dimensions);
        }

        public Product(string name, string data, double cost, double dimensions)
        {
            this.name = name;
            string[] mystring = data.Split('.');
            this.data = new DateTime(Int32.Parse(mystring[2]), Int32.Parse(mystring[1]), Int32.Parse(mystring[0]));
            this.cost = cost;
            this.dimensions = dimensions;
        }

        public override string ToString()
        {
            string str = "Name: " + name + "\nDate: " + data + "\nCost: " + cost + "\nDimensions: " + dimensions;
            return str;
        }
    }
}
