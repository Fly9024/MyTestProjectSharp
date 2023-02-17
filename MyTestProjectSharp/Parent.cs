using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProjectSharp
{
    internal class Parent
    {
        private  int i;
        protected string s;

        protected virtual int I { get => i; set => i = value; }

        public Parent(int i, string s)
        {
            this.I = i;
            this.s = s;
        }

        public void show()
        {
            Console.WriteLine("строковое поле равно {0}, а числовое {1}, а объект, который его вызывает {2}", s, I, GetType().Name);
        }

      
    }


   

}
