using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProjectSharp
{
    internal class Class1
    {


        int num;
        string str;

        public Class1(int num, string str)
        {
            this.num = num;
            this.str = str;
        }

        public int Param
        {
            get
            {
                Console.WriteLine("Было запрошено значение поля");
                return num;
            }
            set
            {
                Console.WriteLine("Было изменено значение поля");
                num = value;
            }
        }

        public override string ToString()
        {
            return "я - объект с числовым полем " + num.ToString() + " и строковым полем "+ str;
        }

        public override bool Equals(object obj)
        {
            Class1 class1 = (Class1)obj ;
            return this.num==class1.num && this.str==class1.str;
        }
        //public override int GetHashCode()
        //{
        //    return 100500;
        //}
        ~Class1()
        {
            Console.WriteLine("Запомните меня таким");
        }



        //переопределение оператора +
        public static Class1 operator +(Class1 c1,Class1 c2)
        {
            return new Class1(c1.num+c2.num, c1.str+c2.str);
        }
         public static int operator +(Class1 c1,int num)
        {
            return c1.num+num;
        }

    }
}
