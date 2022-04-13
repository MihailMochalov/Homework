using System;


namespace Задание_10
{
    class Program
    {
        static void conclusion(int[,] rth, int rows, int columns)
        {

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(rth[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            int m, n;
            Console.WriteLine("Введите кол. столбцов");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол. строчек");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[m, n];
            Random nomber = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = nomber.Next(0, 99);

                }
            }

            conclusion(mas, m, n);
            Console.WriteLine("Введите число");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            int[] newmas = exception(mas, x, m, n);
            if (newmas[0] == -1)
            {
                Console.WriteLine("Данного числа нет в массиве");
            }
            else
            {
                Console.WriteLine($"Координата {newmas[0]} координта {newmas[1]}");
            }
            int[] masnew = calling(mas, m, n);
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($" строка: {i}, {masnew[i]}");
            }
        }
        static int[] exception(int[,] rth, int xx, int rows, int columns)
        {
            int[] mas = new int[2];
            bool find = false;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (xx == rth[i, j])
                    {
                        mas[0] = i;
                        mas[1] = j;
                        find = true;
                        return mas;
                    }

                }

            }
            if (!find)
            {
                mas[0] = -1;
                mas[1] = -1;
            }
            return mas;
        }
        static int[] calling(int[,] rth, int rows, int columns)
        {
            int max;
            int[] nombermas = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                max = rth[i, 0];
                for (int j = 0; j < columns; j++)
                {
                    if (rth[i, j] > max)
                    {
                        max = rth[i, j];
                    }
                }
                nombermas[i] = max;
            }
            return nombermas;
        }

    }

}
