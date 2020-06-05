using System;
using System.Collections.Immutable;
using System.Runtime.InteropServices;

namespace zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ярослава Раскольникова
            //Написать программу, которая запрашивает массу и рост человека, 
            //вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            Console.Write("Введите рост в метрах: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес в килограммах: ");
            double w = Convert.ToDouble(Console.ReadLine());
            double imd = w / (h * h);
            if (imd < 18)
            {
                Console.WriteLine("Недостаточный вес");
                double a = (h * h) * (18 - imd);
                Console.Write("Нужно набрать " + a + " килограмм до нормы");
            }
            else if (imd > 25)
            {    Console.WriteLine("Избыточный вес");
                 double a = (h * h) * (25 - imd);
                Console.Write("Нужно сбросить " + (a * -1) + " килограмм до нормы");
            }
            else
                Console.WriteLine("Все хорошо!");


        }
    }
}
