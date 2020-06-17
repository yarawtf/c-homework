using System;
using System.Text.RegularExpressions;

namespace zadacha_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ярослава Раскольникова
            //Создать программу, которая будет проверять корректность ввода логина. 
            //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы 
            //латинского алфавита или цифры, при этом цифра не может быть первой:
            //a)Без использования регулярных выражений
            
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            string result = "na";


            if (login.Length <= 10 && login.Length >= 2)
            {
                if (char.IsLetter(login[0]))
                {
                    foreach (char ch in login)
                    {
                        if ((int)ch >= 0x0000 && (int)ch <= 0x07F)
                            result = "Добро пожаловать";
                        else
                            result = "Логин должен быть написан латиницей";
                    }

                }
                else
                    result = "Логин должен начинаться с буквы";
            }
            else
                result = "Длина логина должна быть 2-10 символов";

            Console.WriteLine(result);

            //б)*с использованием регулярных выражений
            
            Console.WriteLine("Введите логин");
            string login2 = (Console.ReadLine());

            Regex pattern = new Regex(@"^[^0-9][A-Za-z0-9]{2,10}");
            if (pattern.IsMatch(login2))
                Console.WriteLine("Добро пожаловать");
            else
                Console.WriteLine("Некорректный логин");






















        }
    }
}
