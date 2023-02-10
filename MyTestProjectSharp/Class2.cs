using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProjectSharp
{
    internal class Class2
    {
        int n;

        public Class2(int n)
        {
            this.n = n;
        }

        public static explicit operator int(Class2 c1)
        {
            return c1.n;
        }
        public static explicit operator Class3(Class2 c1)
        {
            Class3 class3 = new Class3(c1.n);
            return class3;
        }

    }
}
