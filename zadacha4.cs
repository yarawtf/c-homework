using System;
using System.Threading;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ярослава Раскольникова
            //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
            //программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
            int count = 0;
            bool a;
            do
            {
                count++;
                a = check("root", "GeekBrains");
                if (a == false)
                    Console.WriteLine("Осталось " + Convert.ToString(3 - count) + " попыток ");
            }
            while (a == false && count < 3);
            if (a == true)
                Console.Write("Glory to Arstozka!");
            else
                Console.Write("Detained");

        }
        static bool check(string a, string b)
        {

            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            if (username == a && password == b)
                return true;
            else
                return false;
        }   

    }
}
