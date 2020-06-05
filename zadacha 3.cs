using System;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3) Ярослава Раскольникова
            //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

            int no = 0;
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                
                if (a % 2 != 0 && a > 0)
                {
                    no = no + a;

                }
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(no);

        }
    }
}
