using System;


namespace Task__8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество чисел");
            int n, nomber, ost, sum;
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            ost = 10;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите число");
                nomber = Convert.ToInt32(Console.ReadLine());
                if ((i == 0) && (nomber % 2 == 0))
                {
                    ost = 0;
                }
                if ((i == 0) && (nomber % 2 > 0))
                {
                    ost = 1;
                }

                if (nomber % 2 == ost)
                {
                    sum = sum + nomber;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
