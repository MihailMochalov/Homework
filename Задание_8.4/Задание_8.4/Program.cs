using System;


namespace Задание_8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел");
            double n;
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите делитель");
            double k;
            k = Convert.ToDouble(Console.ReadLine());
            double temp, a;
            a = 0;
            while (n > 0)
            {
                temp = n % 10;
                if (temp % k == 0)
                {
                    a++;
                }
                n = (n - temp) / 10;
            }
            Console.WriteLine(a);
        }
    }
}
