using System;

namespace zadacha_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3)Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
            //по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
            //Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:F}", r);

        }
    }
}
