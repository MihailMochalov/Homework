using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X;
            Console.WriteLine("ВВидите значение X");
            X = Convert.ToDouble(Console.ReadLine());
            double X3;
            double X2;
            double A = 2;
            double Y;
            X2 = (Math.Pow(X, A) + 4);
            X3 = 1 / (Math.Sqrt(X2));
            Y = (Math.Sqrt(X + X3));
            Console.WriteLine($"Ответ: {Math.Round(Y, 3)}");
        }
    }
}
