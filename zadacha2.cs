using System;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;

namespace zadacha2
{
    class Program
    {
        //Ярослава Раскольникова.
        //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
        //а) Вывести только те слова сообщения,  которые содержат не более n букв.
        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        //в) Найти самое длинное слово сообщения.
        

        static void Main(string[] args)
        {
            
            
            int num = 3;
            string mes = "Что это происходит помогите";
            char a = Convert.ToChar(Console.ReadLine());

            
            Console.WriteLine(Message.WordLength(num, mes));
            Console.WriteLine(Message.Delete(a, mes));
            Console.WriteLine(Message.Longest(mes));

        }

    }
    public static class Message
    {


        public static string WordLength(int num, string mes)
        {
            char[] div = { ' ' };
            string newmes = "";
            string[] parts = mes.Split(div);
            for (int i = 0; i < parts.Length; i++)
                if (parts[i].Length <= num)
                    newmes = newmes + " " + parts[i];
            return newmes;
        }

        public static string Delete(char a, string mes)
        {
            char div = ' ';
            string newmes = "";
            string[] parts = mes.Split(div);
            for (int i = 0; i < parts.Length; i++)
                if (parts[i].EndsWith(a))
                {
                    newmes = newmes + " " + parts[i].Remove(0, parts[i].Length);
                }
                else
                    newmes = newmes + " " + parts[i];
            return newmes;
        }

        public static string Longest(string mes)
        {
            char[] div = { ' ' };
            string newmes = "";
            string[] parts = mes.Split(div);
            for (int i = 1; i < parts.Length; i++)
                if (parts[i].Length > parts[i - 1].Length)
                    newmes = parts[i];
            return newmes;
        }

        

    }
}