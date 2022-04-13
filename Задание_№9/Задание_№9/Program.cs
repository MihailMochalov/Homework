using System;

namespace Задание__9
{
    class Program
    {
        static void Main()
        {
            int[] mas = new int[10];
            int a, d;
            Console.WriteLine("Введите первое значение прогресси");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите разность прогресси");
            d = Convert.ToInt32(Console.ReadLine());
            nomber(ref mas, a, d);
            shouw(mas);
            Console.WriteLine("\nВведите переменную k");
            int k;
            k = Convert.ToInt32(Console.ReadLine());
            klass(ref mas, k);
            shouw(mas);
            rtr(mas);
            Console.WriteLine("Введите стпень");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            step(n, mas);
        }
        static void nomber(ref int[] mas, int a, int d)
        {

            for (int i = 0; i < mas.Length; i++)
            {

                mas[i] = a + i * d;


            }

        }
        static void shouw(int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                Console.Write($" {mas[i]}, ");

            }
            Console.WriteLine(mas[mas.Length - 1]);
        }
        static void klass(ref int[] mas, int k)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = mas[i] + k;
            }
        }
        static void rtr(int[] mas)
        {
            int n;
            n = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 > 0)
                {
                    n = n + 1;

                }

            }

            Console.WriteLine($"Количество нечетных чисел {n}");
        }
        static void step(int n, int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = (int)Math.Pow(mas[i], n);
            }
            shouw(mas);
        }
    }
}
