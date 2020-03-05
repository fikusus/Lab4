using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    public class B:A
    {
        private int d;

        public B(int a, int b):base(a,b)
        {
            d = 0;
        }

        public B(int a, int b, int d) : base(a, b)
        {
            this.d = d;
        }

        public int c2()
        {
            if (a >= b)
            {
                if(a >= d)
                {
                    return a;
                }
                else
                {
                    return d;
                }
            }
            else 
            {
                if (b >= d)
                {
                    return b;
                }
                else
                {
                    return d;
                }
            }

        }
        public void print(string name)
        {
            Console.WriteLine(name + ":a = " + a + " b = " + b + " d = " + d);
        }
    }
}
