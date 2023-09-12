using System;

namespace Praktika_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Сумма чисел " + a + " и " + b + " равна " + c);
        }
    }
}
