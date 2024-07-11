using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,50);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Cумму максимального и минимального значения равна: {array.Max() + array.Min()}");
            Console.ReadKey();
        }
    }
}
