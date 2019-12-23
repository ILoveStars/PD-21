/*Написати програму, що виконує наступні функції:
1. Виводить на екран введене число з клавіатури в зворотному порядку(1234-4321)
2. Виводить будь-яку строку в зворотному порядку(АБВ-ВБА)
3. Дробові числа виводяться в зворотному порядку і ціла частина і дробова(123.456-321.654)
4. Виводити будь-яку строку в зворотному порядку і всі елементи після “магічного
знаку” теж в зворотному(АБВ,ГДЕ-ВБА,ЕДГ)
5. Реалізувати пункти 1-4 за допомогою методів, перевантаживши методи для різних
типів
6. Реалізувати пункти 1-4 за допомогою рекурсії, методи для різних типів
перевантажити
7. Реалізувати метод, що буде масив повертати задом навпаки(Використання
Array.Reverse() заборонено!)
8. Виконати пункт 7 з використанням ключових слів ref i out*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба7___методи
{
    class Program
    {
        static void NumberTransform()
        {
            Console.WriteLine("Please, enter your number");
            string number = Console.ReadLine();
            char[] line = number.ToCharArray();
            Array.Reverse(line);
            Console.Write("Transformed number: ");
            Console.Write(line);
        }

        static void StringTransform()
        {
            Console.WriteLine("Please, enter your string");
            string str = Console.ReadLine();
            char[] line = str.ToCharArray();
            Array.Reverse(line);
            Console.Write("Transformed string: ");
            Console.Write(line);
        }

        static void FractionalNumberTransform()
        {
            string number;
            do {
                Console.WriteLine("Please, enter your number. It must be fractional");
                number = Console.ReadLine();
            } while (Convert.ToDouble(number) % 1 == 0);
            char[] line = number.ToCharArray();

            Console.Write("Transformed number: ");
            for (int i = 0; i < line.Length; i++)
                if (line[i] == ',')
                {
                    int k = i;
                    for (i = k - 1; i >= 0; i--)
                        Console.Write(line[i]);
                    Console.Write(",");
                    for (i = line.Length - 1; i > k; i--)
                        Console.Write(line[i]);
                }
        }
        
        static void DividedStringTransform()
        {
            string str;
            Console.WriteLine("Please, enter your string");
            str = Console.ReadLine();
            char[] line = str.ToCharArray();

            char magicsymbol;
            Console.WriteLine("Please, enter magic symbol");
            magicsymbol = Convert.ToChar(Console.ReadLine());

            bool check = false;
            for (int i = 0; i < line.Length; i++)
                if (line[i] == magicsymbol)
                    check = true;

            if (check == true)
            {
                Console.Write("Transformed string: ");
                for (int i = 0; i < line.Length; i++)
                    if (line[i] == magicsymbol)
                    {
                        int k = i;
                        for (i = k - 1; i >= 0; i--)
                            Console.Write(line[i]);
                        Console.Write(magicsymbol);
                        for (i = line.Length - 1; i > k; i--)
                            Console.Write(line[i]);
                    }
            }
            else
                Console.Write("Your string does not contain magic symbol");
        }

        abstract class ViceVersa
        {
            public static void Transform(int number)
            {
                string str = Convert.ToString(number);
                char[] line = str.ToCharArray();
                Array.Reverse(line);
                Console.Write("Transformed number: ");
                Console.Write(line);
            }

            public static void Transform(string str)
            {
                char[] line = str.ToCharArray();
                Array.Reverse(line);
                Console.Write("Transformed string: ");
                Console.Write(line);
            }

            public static void Transform(double number)
            {
                string str = Convert.ToString(number);
                char[] line = str.ToCharArray();

                Console.Write("Transformed number: ");
                for (int i = 0; i < line.Length; i++)
                    if (line[i] == ',')
                    {
                        int k = i;
                        for (i = k - 1; i >= 0; i--)
                            Console.Write(line[i]);
                        Console.Write(",");
                        for (i = line.Length - 1; i > k; i--)
                            Console.Write(line[i]);
                    }
            }

            static void Transform(string str, char magicsymbol)
            {
                char[] line = str.ToCharArray();

                bool check = false;
                for (int i = 0; i < line.Length; i++)
                    if (line[i] == magicsymbol)
                        check = true;

                if (check == true)
                {
                    Console.Write("Transformed string: ");
                    for (int i = 0; i < line.Length; i++)
                        if (line[i] == magicsymbol)
                        {
                            int k = i;
                            for (i = k - 1; i >= 0; i--)
                                Console.Write(line[i]);
                            Console.Write(magicsymbol);
                            for (i = line.Length - 1; i > k; i--)
                                Console.Write(line[i]);
                        }
                }
                else
                    Console.Write("Your string does not contain magic symbol");
            }
        }

        static int[] ArrayTransform(int[] a)
        {
            int i, j, t;
            for (i = 0, j = a.Length - 1; i < j; i++, j--)
            {
                t = a[i];
                a[i] = a[j];
                a[j] = t;
            }
            return a;
        }

        static void RefArrayTransform(ref int[] a)
        {
            int i, j, t;
            for (i = 0, j = a.Length - 1; i < j; i++, j--)
            {
                t = a[i];
                a[i] = a[j];
                a[j] = t;
            }
        }

        static void OutArrayTransform(out int[] a)
        {
            int n;
            do
            {
                Console.WriteLine("Please, enter number of elements in your array. It must be bigger than 0");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            a = new int[n];

            int i = 0;
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}] = ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int j, t;
            for (i = 0, j = a.Length - 1; i < j; i++, j--)
            {
                t = a[i];
                a[i] = a[j];
                a[j] = t;
            }
        }

        static void Main(string[] args)
        {
            //NumberTransform();
            //StringTransform();
            //FractionalNumberTransform();
            //DividedStringTransform();
            //ViceVersa.Transform(a);
            //ArrayTransform(out a);
            //RefArrayTransform(ref a);
            //OutArrayTransform(out a);

            Console.WriteLine("Welcome! This program allows you to transform numbers, strings or arrays with different methods");
            Console.WriteLine("1. Reverse number");
            Console.WriteLine("2. Reverse string");
            Console.WriteLine("3. Reverse fractional number");
            Console.WriteLine("4. Reverse string with magic symbol");
            Console.WriteLine("5. Reverse number (overload)");
            Console.WriteLine("6. Reverse string (overload)");
            Console.WriteLine("7. Reverse fractional number (overload)");
            Console.WriteLine("8. Reverse string with magic symbol (overload)");
            Console.WriteLine("9. Reverse array");
            Console.WriteLine("10. Reverse array using ref");
            Console.WriteLine("11. Reverse array using out");
            int method;
            do
            {
                Console.WriteLine("\nWhich method do you want to use? (1-11)");
                method = Convert.ToInt32(Console.ReadLine());
            } while (method <= 0 || method > 11);


            switch (method)
            {
                case 1:
                    NumberTransform();
                    break;
                case 2:
                    StringTransform();
                    break;
                case 3:
                    FractionalNumberTransform();
                    break;
                case 4:
                    DividedStringTransform();
                    break;
                case 5:
                    Console.WriteLine("Please, enter your number");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    ViceVersa.Transform(number1);
                    break;
                case 6:
                    Console.WriteLine("Please, enter your string");
                    string str1 = Console.ReadLine();
                    ViceVersa.Transform(str1);
                    break;
                case 7:
                    Console.WriteLine("Please, enter your rational number");
                    double number2 = Convert.ToDouble(Console.ReadLine());
                    ViceVersa.Transform(number2);
                    break;
                case 8:
                    Console.WriteLine("Please, enter your string");
                    string str2 = Console.ReadLine();
                    Console.WriteLine("Please, enter magic symbol");
                    char magicsymbol = Convert.ToChar(Console.ReadLine());
                    ViceVersa.Transform(str2);
                    break;
                case 9:
                    int[] a1;
                    int n1;
                    do
                    {
                        Console.WriteLine("Please, enter number of elements in your array. It must be bigger than 0");
                        n1 = Convert.ToInt32(Console.ReadLine());
                    } while (n1 <= 0);
                    a1 = new int[n1];
                    for (int i = 0; i < n1; i++)
                    {
                        Console.Write("a[{0}] = ", i + 1);
                        a1[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    ArrayTransform(a1);
                    Console.WriteLine("\nNew Array:");
                    for (int i = 0; i < n1; i++)
                        Console.WriteLine("a[{0}] = {1}", i + 1, a1[i]);
                    break;
                case 10:
                    int[] a;
                    int n;
                    do
                    {
                        Console.WriteLine("Please, enter number of elements in your array. It must be bigger than 0");
                        n = Convert.ToInt32(Console.ReadLine());
                    } while (n <= 0);
                    a = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("a[{0}] = ", i + 1);
                        a[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    RefArrayTransform(ref a);
                    Console.WriteLine("\nNew Array:");
                    for (int i = 0; i < n; i++)
                        Console.WriteLine("a[{0}] = {1}", i + 1, a[i]);
                    break;
                case 11:
                    int[] a3;
                    OutArrayTransform(out a3);
                    Console.WriteLine("\nNew Array:");
                    for (int i = 0; i < a3.Length; i++)
                        Console.WriteLine("a[{0}] = {1}", i + 1, a3[i]);
                    break;
            }
            
            Console.ReadKey();
        }
    }
}