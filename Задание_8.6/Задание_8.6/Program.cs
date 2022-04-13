using System;


namespace Задание_8._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, n, sum;
            Console.WriteLine("Введите число A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            for (int i = a; i < b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (sum == n)
                {
                    Console.WriteLine(i);
                }
                sum = 0;
            }
        }
    }
}
