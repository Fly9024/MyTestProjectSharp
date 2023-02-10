using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProjectSharp
{
    internal class Class3
    {
        int n;

        public Class3(int n)
        {
            this.n = n;
        }

        public static implicit operator int(Class3 c1)
        {
            return c1.n;
        }


    }
}
