using System;


namespace Задание_8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел");
            double n;
            n = Convert.ToDouble(Console.ReadLine());
            double k;
            k = 0;
            double temp;
            while (n > 0)
            {
                temp = n % 10;
                k = temp + k;
                n = (n - temp) / 10;
                if (n != 0)
                {
                    k = k * 10;
                }
            }
            Console.WriteLine(k);
        }
    }
}
