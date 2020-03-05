using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    public class A
    {
        protected int a;
        protected int b;
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }


        public int C()
        {
            return a + b;  
        }

        public void print(string name)
        {
            Console.WriteLine(name + ":a = " + a + " b = " + b);
        }
    }
}
