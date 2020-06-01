using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4)Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;

            int a = 5;
            int b = 1;
            Console.WriteLine($"a = {b}, b = {a}");


            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {b}, b = {a}");

        }
    }
}
