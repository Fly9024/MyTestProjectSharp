using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestProjectSharp
{
    internal class Arrays
    {
        object array;
        int razm;
        Random random = new Random();   
        public Arrays(int n,int m)
        {
          
            int[,] int2 = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int2[i, j] = random.Next(100);
                }
            }


            array = int2;
            razm = 2;
        }

        public Arrays(int n)
        {
            razm = 1;            
            int[] int1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                int1[i] = random.Next(100);
            }
            array = int1;
        }

        public void showArray()
        {
            switch (razm)
            {
                case 1:
                    int[] int1 = (int[])array;
                    for (int i = 0; i < int1.Length; i++)
                    {
                        Console.Write( $"{int1[i]} ");
                    }
                    break;
                case 2:
                    int[,] int2 = (int[,])array;
                    for (int i = 0; i < int2.GetLength(0); i++)
                    {
                        for (int j = 0; j < int2.GetLength(1); j++)
                        {
                            Console.Write($"{int2[i,j]} ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
               
        }


        public int this[int k]
        {
            get
            {
                int[] int1 = (int[])array;
                return int1[k];
            }
            set
            {
                int[] int1 = (int[])array;
                int1[k] = value;
            }
        } 
        public int this[int k,int m]
        {
            get
            {
                int[,] int2 = (int[,])array;
                return int2[k,m];
            }
            set
            {
                int[,] int2 = (int[,])array;
                int2[k,m] = value;
            }
        }
    }
}
