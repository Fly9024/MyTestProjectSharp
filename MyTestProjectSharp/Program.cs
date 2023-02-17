using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace MyTestProjectSharp
{
     class Person
    {
        int age;
        string familyName;

        public void whoAmI()
        {
            Console.WriteLine("моя фамилия {0}, мне {1} лет",familyName,age);   
        }

        public Person(int age, string familyName)
        {
            this.age = age;
            this.familyName = familyName;            
        }

        public void myMethod(int a)
        {
            Console.WriteLine("мне передали целое число");
        }
        public void myMethod(double a)
        {
            Console.WriteLine("мне передали вещественное число");
        }
        public void myMethod(string a)
        {
            Console.WriteLine("мне передали строку");
        }
        
    }


   
    class Massivi
    {
        int[] myIntArrayForSomething = new int[1];
        
        public Massivi(int n)
        {
            Random random = new Random();
            Array.Resize(ref myIntArrayForSomething, n);
           
            for (int i=0; i< myIntArrayForSomething.Length;i++)
            {                
                myIntArrayForSomething[i] = random.Next(100);               
            }
        }
        public void showArray()
        {
            foreach (int i in myIntArrayForSomething)
            {                
                Console.Write("{0} ", i);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public void arraySort()
        {
            Array.Sort(myIntArrayForSomething);           
           // Array.Reverse(myIntArrayForSomething);
        }
    }

    internal class Program
    {
        static double MROT = 13000;
        static double nalog(double count)
        {
            if (count<MROT)
            {
                throw new Exception("Зарплата ниже прожиточного минимума");
            }
            return count *0.13;
        }
        
        static void Main(string[] args)
        {

            Child2 child2 = new Child2(585,"Еще строка",6.22);
            child2.showChild();

            Console.ReadKey();


           
        }
    }
}
