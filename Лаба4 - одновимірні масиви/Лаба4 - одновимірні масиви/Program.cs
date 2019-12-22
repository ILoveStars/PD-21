//Даний масив розміру N. Вивести спочатку його елементи з парними(непарними) індексами, а потім — з непарними(парними).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба4___одновимірні_масиви
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do {
                Console.WriteLine("Please, enter N. It must be greater than 0");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            int[] a = new int[n];
            for (int i = 0; i < n; i++) {
                Console.WriteLine("a[{0}]:", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nElement output:");
            for (int i = 0; i < n; i++)
                if ((i + 1) % 2 == 0)
                    Console.WriteLine("a[{0}] = {1}", i + 1, a[i]);
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
                if ((i + 1) % 2 != 0)
                    Console.WriteLine("a[{0}] = {1}", i + 1, a[i]);

            Console.ReadKey();
        }
    }
}
