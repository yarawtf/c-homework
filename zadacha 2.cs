using System;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2) Ярослава Раскольникова
            //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            //Сами числа и сумму вывести на экран, используя tryParse.

            int no = 0;
            while (true)
            {
                int.TryParse(Console.ReadLine(), out int a);
                if (a % 2 != 0 && a > 0)
                {
                    no = no + a;
                }
                if (a == 0)
                    break;
            }
            Console.WriteLine(no);
        }    

}   }
