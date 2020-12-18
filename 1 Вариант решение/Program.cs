using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Вариант_решение
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("R=3x^2 +3y^5 +4.9");
            Random rand = new Random();
            int x = rand.Next(0,99);
            int y = rand.Next(0,99);

            Double R = 3 * Math.Pow(x, 2) + 3 * Math.Pow(y, 5) + 4.9;
            Console.WriteLine($"x= {x}");
            Console.WriteLine($"y= {y} ");
            Console.WriteLine($"R={R}");
            Console.ReadLine();



        }
    }
}
