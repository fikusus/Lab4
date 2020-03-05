using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1

{
    class Program
    {
        public static void Main(string[] args)
        {
            Son son = new Son(12);
            Son son2 = new Son();
            Dad dad = new Dad(36);
            Console.ReadKey();
        }
    }
    public class Dad
    {
        int a;
        public Dad(int s)
        {
            this.a = s;
            Console.WriteLine(this.a);
        }
    }
    public class Son : Dad
    {
        public Son(int k) : base(k) { }
        public Son() : this(10) { }
    }
}
