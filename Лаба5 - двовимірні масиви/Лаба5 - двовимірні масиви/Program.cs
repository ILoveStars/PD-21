//Дана матриця розміру m * n. Знайти суми елементів всіх її 1) парних; 2) непарних строк(стовпчиків).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба5___двовимірні_масиви
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            do
            {
                Console.WriteLine("Please, enter numver of rows. It must be greater than 0");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            do
            {
                Console.WriteLine("Please, enter number of columns. It must be greater than 0");
                m = Convert.ToInt32(Console.ReadLine());
            } while (m <= 0);

            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("a[{0}{1}]:", i + 1, j + 1);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            Console.WriteLine("");

            int s11 = 0;
            int s12 = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                { 
                    if ((i + 1) % 2 == 0)
                        s11 = s11 + a[i, j];
                    if ((j + 1) % 2 == 0)
                        s12 = s12 + a[i, j];
                }

            int s21 = 0;
            int s22 = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    if ((i + 1) % 2 != 0)
                        s21 = s21 + a[i, j];
                    if ((j + 1) % 2 != 0)
                        s22 = s22 + a[i, j];
                }

            Console.WriteLine("The sum of the elements of the paired rows is {0}", s11);
            Console.WriteLine("The sum of the elements of the paired columns is {0}", s12);

            Console.WriteLine("The sum of the elements of the unpaired rows is {0}", s21);
            Console.WriteLine("The sum of the elements of the unpaired columns is {0}", s22);

            Console.ReadKey();
        }
    }
}
