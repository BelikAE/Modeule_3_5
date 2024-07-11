using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива N");
            int n= Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n,n];
            Boolean boolArray = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (boolArray)
                    {
                        array[i, j] = 1;
                        Console.Write($"{array[i, j]} ");
                        boolArray = false;
                        continue;
                    }
                    else 
                    {
                        array[i, j] = 0;
                        Console.Write($"{array[i, j]} ");
                        boolArray = true;
                        continue;
                    }
                    
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();

        }
    }
}
