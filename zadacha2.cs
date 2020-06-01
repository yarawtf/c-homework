using System;

namespace zadacha_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) 
            //по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

            Console.Write("Введите рост: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вес:");
            int weight = Convert.ToInt32(Console.ReadLine());
            double imt = (double) weight / (height * height);
            Console.Write(imt);





        }
    }
}
