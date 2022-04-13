using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rost;
            double sum = 0;
            for (int i = 0; i < 5; i = i + 1)
            {
                Console.WriteLine("ВВедите рост");
                rost = Convert.ToDouble(Console.ReadLine());
                sum = sum + rost;
            }
            Console.WriteLine($"Средний рост студентов: {sum / 5 }");
        }
    }
}
