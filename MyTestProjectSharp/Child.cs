using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProjectSharp
{
    internal class Child:Parent
    {
        public Child(int i, string s) : base(i, s)
        {
        }

        public void showCchild()
        {
            Console.WriteLine(s);
        }

    }
     internal class Child2:Parent
    {
        double d;
        string s;
        static string str = "строка из дочернего класса";

        public Child2(int i, string s,double d) : base(i, s)
        {
            this.d = d;
        }

        public Child2() : base(0, str)
        {
            
        }

        //public Child2(double d)
        //{
        //    this.d = d;
        //}
        //public Child2(int i,string s)
        //{ 
        //    this.d = 1.00;
        //    this.s = s;
        //    this.i = i;
        //}

        public void showChild()
        {
            Console.WriteLine("{0} {1} {2}",I,s,d);
        }

        protected override int I { get => base.I; set => base.I = value; }
    }



}
