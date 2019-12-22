//Обчислити суму числового ряду для заданих початкових індексів nn та nk ((k ^ 3 + (-1) ^ 2 * k - 1) / (k ^ 2 + 3))
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба2___нескінченний_ряд
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn, nk;
            do {
                Console.WriteLine("Please, enter nn. It must be greater than or equal to zero");
                nn = Convert.ToInt32(Console.ReadLine());
            } while (nn < 0);
            do
            {
                Console.WriteLine("Please, enter nk. It must be greater than or equal to nn");
                nk = Convert.ToInt32(Console.ReadLine());
            } while (nk < nn);

            int k = nn;
            int s = 0;
            for (int i = nn; i < nk; i++)
            {
                s = s + (k ^ 3 + (-1) ^ 2 * k - 1) / (k ^ 2 + 3);
                k++;
            }
            Console.WriteLine("\nThe sum is {0}", s);

            Console.ReadKey();
        }
    }
}
