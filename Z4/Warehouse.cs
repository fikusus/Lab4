using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    enum SortType
    {
        Cost,
        Name,
        Dimensions
    }

    class Warehouse
    {
        public LinkedList<Product> products { get; private set; } = new LinkedList<Product>();



        public void Add(Product item)
        {
            products.AddLast(item);
        }


        public LinkedList<Product> Sort(SortType type)
        {
            Product[] temp = products.ToArray<Product>();
            switch (type){
                case SortType.Cost:
                    double[] costArr = new double[temp.Length];
                       for(int i = 0; i < temp.Length; i++)
                    {
                        costArr[i] = temp[i].cost;
                    }
                    Array.Sort(costArr, temp);
                    break;
                case SortType.Name:
                    string[] nameArr = new string[temp.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        nameArr[i] = temp[i].name;
                    }
                    Array.Sort(nameArr, temp);
                    break;
                case SortType.Dimensions:
                    double[] dimArr = new double[temp.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        dimArr[i] = temp[i].dimensions;
                    }
                    Array.Sort(dimArr, temp);
                    break;
            }
            return new LinkedList<Product>(temp);
        }


        public LinkedList<Product> Find(double cost)
        {
            LinkedList<Product> result = new LinkedList<Product>();
            foreach (var item in products)
            {
                if(item.cost == cost)
                {
                    result.AddLast(item);
                }
            }
            return result;
        }

        public LinkedList<Product> Find(string name)
        {
            LinkedList<Product> result = new LinkedList<Product>();
            foreach (var item in products)
            {
                if (item.name == name)
                {
                    result.AddLast(item);
                }
            }
            return result;
        }

        public LinkedList<Product> Find(DateTime data)
        {
            LinkedList<Product> result = new LinkedList<Product>();
            foreach (var item in products)
            {
                if (item.data.Equals(data))
                {
                    result.AddLast(item);
                }
            }
            return result;
        }
    }
}
