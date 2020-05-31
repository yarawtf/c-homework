using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace text
{
    class Program
    {
        static void Main(string[] args)
        {

            //  1)Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            //а) используя склеивание;

            Console.Write("Введите имя:");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию:");
            string lastname = Console.ReadLine();
            Console.Write("Введите рост:");
            string height = Console.ReadLine();
            Console.Write("Введите возраст:");
            string age = Console.ReadLine();
            Console.Write("Введите вес:");
            string weight = Console.ReadLine();
            Console.Write(name + lastname + height + age + weight);


            //   2)Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
            //где m — масса тела в килограммах, h — рост в метрах.
            Console.Write("Введите рост:");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес:");
            double w = Convert.ToDouble(Console.ReadLine());
            double imt = w / (h * h);
            Console.Write(imt);


            //3)Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;

            int x = 56;
            int y = 20;
            int z = x;
            y = x;
            x = y;




        }


            
         

    }   
}
