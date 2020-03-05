using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A(10, 15);
            B b1 = new B(15, -5);
            B b2 = new B(2, 5, 7);
            a1.print("a1");
            Console.WriteLine("Результат работы метода C объекта a1(сумма):" + a1.C());

            b1.print("b1");
            Console.WriteLine("Результат работы метода C объекта b1(сумма):" + b1.C());
            Console.WriteLine("Результат работы метода c2 объекта b1(max):" + b1.c2());

            b2.print("b2");
            Console.WriteLine("Результат работы метода C объекта b2(сумма):" + b2.C());
            Console.WriteLine("Результат работы метода c2 объекта b2(max):" + b2.c2());
            Console.ReadKey();
        }
    }
}
