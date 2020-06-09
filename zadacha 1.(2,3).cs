using System;

namespace zadacha2
{
    class Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }
        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = this.im - x2.im;
            x3.re = this.re - x2.re;
            return x3;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите действительную часть первого числа:");
            
            Complex complex1 = new Complex();
            complex1.re = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите мнимую часть первого числа:");
            complex1.im = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите действительную часть второго числа:");
            Complex complex2 = new Complex();
            complex2.re = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите мнимую часть второго числа:");
            complex2.im = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Доступны 3 операции:");
            Console.WriteLine("Нажмите 1 чтобы сложить числа");
            Console.WriteLine("Нажмите 2 чтобы умножить числа");
            Console.WriteLine("Нажмите 3 чтобы вычесть числа");
            
            string choice = Console.ReadLine();
            Complex result = new Complex();
            switch (choice)
            {
                case "1": 
                    result = complex1.Plus(complex2);
                    break;
                case "2":
                    result = complex1.Multi(complex2);
                    break;
                case "3":
                    result = complex1.Minus(complex2);
                    break;
                default: Console.WriteLine("Непонятно");
                    break;

            }
            Console.WriteLine(result.ToString());
            


        }
    }

}
