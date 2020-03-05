using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();

            warehouse.Add(new Product("Orange", "20.03.2019", 430, 200));
            warehouse.Add(new Product("Milk", "20.03.2019", 50, 435));
            warehouse.Add(new Product("Carrot", "09.12.2018", 622, 452));

            Console.WriteLine("Начальный массив:");
            printList(warehouse.products);

            Console.WriteLine("\nСортировака по имени:");
            printList(warehouse.Sort(SortType.Name));

            Console.WriteLine("\nСортировака по цене:");
            printList(warehouse.Sort(SortType.Cost));

            Console.WriteLine("\nСортировака по объему:");
            printList(warehouse.Sort(SortType.Dimensions));

            Console.WriteLine("\nВведи дату в формате DD.MM.YYY для поиска товаров:");
            string[] mystring = Console.ReadLine().Split('.');
            try
            {
                printList(warehouse.Find(new DateTime(Int32.Parse(mystring[2]), Int32.Parse(mystring[1]), Int32.Parse(mystring[0]))));
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка входных данных");
                Environment.Exit(1);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка входных данных");
                Environment.Exit(1);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка входных данных");
                Environment.Exit(1);
            }

            Console.WriteLine("\nВведи название товара для поиска:");
            printList(warehouse.Find(Console.ReadLine()));

            Console.WriteLine("\nВведи цену товара для поиска:");
            try
            {
                printList(warehouse.Find(double.Parse(Console.ReadLine())));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка входных данных");
                Environment.Exit(1);

            }
            Console.ReadKey();
        }


        private static void printList(LinkedList<Product> products)
        {
            if (products.Count != 0)
            {
                foreach (var item in products)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Массив товаров пуст");
            }

        }
    }
}
