//Перевірити істинність вислову: "Дані числа x, у є координатами точки, що лежить у другому квадранті"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба3___логічні_вирази
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            bool quad;

            Console.WriteLine("Please, enter x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter y");
            y = Convert.ToInt32(Console.ReadLine());

            if (x < 0 && y > 0)
                quad = true;
            else
                quad = false;

            if (quad == true)
                Console.WriteLine("The point lies in the second quadrant");
            if (quad == false)
                Console.WriteLine("The point does not lie in the second quadrant");

            Console.ReadKey();
        }
    }
}
