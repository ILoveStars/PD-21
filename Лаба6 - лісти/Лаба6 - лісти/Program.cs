//Створити ліст трінгових змінних, дозволити можливість заповнення з калвіатури.Вивести індекси змінних рівних перевірочній(теж ввести з клавіатури). Скопіювати ліст в масив.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба6___лісти
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Please, enter number of strings in your list. It must be greater than 0");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            string check;
            Console.WriteLine("Please, enter checking string");
            check = Console.ReadLine();

            List<string> str = new List<string>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("The {0} string is:", i + 1);
                str.Add(Console.ReadLine());
            }

            int index = str.IndexOf(check);
            if (index < 0)
                Console.WriteLine("\nList does not contain variables identical to checking");
            else
            {
                Console.WriteLine("\nIndexers of variables identical to checking:");
                for (int i = 0; i < n; i++)
                {
                    i = index;
                    Console.WriteLine("{0}", index);
                    index = str.IndexOf(check, index + 1);
                }
            }

            string[] s = new string[n];
            Console.WriteLine("\nCopying list into the array...");
            str.CopyTo(s);
            Console.WriteLine("Array output:");
            for (int i = 0; i < n; i++)
                Console.WriteLine("s[{0}]:\n{1}", i + 1, s[i]);
            
            Console.ReadKey();
        }
    }
}
