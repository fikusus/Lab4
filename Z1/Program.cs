﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            A test = new A();
            Console.WriteLine("Результат работы метода C класса А:" + test.C());
            Console.ReadKey();
        }
    }
}
