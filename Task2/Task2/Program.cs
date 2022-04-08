using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Programm
    {
        public static void Main()
        {
            double Rebro;

            Console.WriteLine("ВВедите ребро октаэдр");
            Rebro = Convert.ToDouble(Console.ReadLine());
            double S;
            double V;
            double a = 3;
            double c = 2;
            S = (Math.Pow(Rebro, c) * Math.Sqrt(a)) * 2;
            V = (Math.Pow(Rebro, a) * Math.Sqrt(c)) / 3;
            Console.WriteLine($"Ответ: Площадь равна {S} Объем равен {V}");
        }
    }
}
