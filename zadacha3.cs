using System;
using System.Linq;

namespace zadacha_3
{

    //а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив заданной 
    //размерности и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, 
    //которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi, 
    //умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных 
    //элементов. В Main продемонстрировать работу класса.

    class MyArray
    {
        int[] a;
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = min + i * 5;

        }
        
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
        public int Sum
        {
            get 
            {
                int sum = a[0];
                for (int i = 1; i < a.Length; i++)
                    sum+= a[i];
                return sum;
            }   
        
        }

        public int MaxCount
        {
            get
            {
                int maxcount = a.Max();
                int counts = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] == maxcount)
                    {
                        counts++;
                    }
                return counts;
               
            }
        }
        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
                a[i]*= -1;
        }

        public void Multi()
        {
            for (int i = 0; i < a.Length; i++)
                a[i] *= 2; 
        }
    
    }   



    class Program
    {
        static void Main(string[] args)
        {
            MyArray ma = new MyArray(10, 5, 100);
            Console.WriteLine(ma.ToString());
            Console.WriteLine(ma.Max);
            Console.WriteLine(ma.Min);
            Console.WriteLine(ma.CountPositiv);
            Console.WriteLine(ma.Sum);
            Console.WriteLine(ma.MaxCount);
            ma.Inverse();
            Console.WriteLine(ma.ToString());
            ma.Inverse();
            ma.Multi();
            Console.WriteLine(ma.ToString());
            
        }       
    }


    
}
