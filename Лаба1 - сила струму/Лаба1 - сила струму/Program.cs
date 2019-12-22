//Обчислення сили струму по відомим значенням напруги та опору електричного ланцюга
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба1___сила_струму
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter U");
            double u = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, enter R");
            double r = Convert.ToDouble(Console.ReadLine());

            double i = u / r;
            Console.WriteLine("\nI = {0}", i);

            Console.ReadKey();
        }
    }
}
