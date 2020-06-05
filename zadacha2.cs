using System;
using System.Threading;

namespace zadacha2
{
    class Program
    {
        //2)Ярослава Раскольникова
        //Написать метод подсчета количества цифр числа.
        static void Main(string[] args)
        {
            Console.WriteLine(numbercount(-42));
        }
        
        static int numbercount(int a)
        {
            int count = 0;
            while (a != 0)
            {
                a = a / 10;
                count++;

            }
            return count;
        }

    }
}
