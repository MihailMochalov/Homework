using System;


namespace Задание_3
{
    internal class Program
    {
        static void Main()
        {
            double x, x3, x2, Y, A;
            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());
            x3 = 0;
            x2 = 0;
            Y = 0;
            A = 0;
            nomber(x, ref x3, ref x2, ref Y, ref A);
            Console.WriteLine($"Ответ: {Math.Round(Y, 3)}");

        }


        static void nomber(double x, ref double x3, ref double x2, ref double Y, ref double A)
        {


            x2 = (Math.Pow(x, A) + 4);
            x3 = 1 / (Math.Sqrt(x2));
            Y = (Math.Sqrt(x + x3));

        }
    }
}

