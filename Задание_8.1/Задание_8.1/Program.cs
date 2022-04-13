using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите переменную: ");
            int a, b, n;
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите переменную: ");
            b = Convert.ToInt32(Console.ReadLine());
            int sum;
            sum = 0;
            while (a <= b)
            {
                n = (int)Math.Pow(a, 3);
                a++;
                sum = sum + n;
            }
            Console.WriteLine(sum);
        }
    }
}
