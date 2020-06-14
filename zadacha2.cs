using System;
using System.IO;

namespace ConsoleApp1
{
      
     struct Account
     {
        public string login;
        public string password;

    }
    class Program
    {
        static bool Check(Account user)
        {
            //1.Ярослава Раскольникова. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. 
            //Создайте структуру Account, содержащую Login и Password
            
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            
            if (username == user.login && password == user.password)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            string[] logpass = File.ReadAllLines("logpass.txt");

            Account user;
            user.login = logpass[0];
            user.password = logpass[1];
            Console.WriteLine(Check (user));

        }

    }
    
}
