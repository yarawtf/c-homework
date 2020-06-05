using System;

namespace zadacha_1
{
    class Program
    {

        //Раскольникова Ярослава
        //1)Написать метод, возвращающий минимальное из трех чисел
        static void Main(string[] args)
        {
            Console.WriteLine(Min(0, 10, 5));
            
        }

        static double Min(double a, double b, double c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < a && b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

    }
}
