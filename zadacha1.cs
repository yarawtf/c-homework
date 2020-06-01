using System;

namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
            //а) используя склеивание



            Console.Write("Введите имя:");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию:");
            string lastname = Console.ReadLine();
            Console.Write("Введите рост:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите возраст:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вес:");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Имя: " + name + ", Фамилия: " + lastname + ", Рост: " + height + ", Возраст: " + age + ", Вес: " + weight);


            //b)Используя форматированный вывод
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Рост: {2}, Возраст: {3}, Вес: {4}",
                name,
                lastname,
                height,
                age,
                weight);

            //c) Используя вывод со знаком $
            Console.WriteLine($"Имя: {name}, Фамилия: {lastname}, Рост: {height}, Возраст: {age}, Вес: {weight}");





        }
    }
}
