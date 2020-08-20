using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаём рандомное число.
            Random rnd = new Random();
            int N = rnd.Next(1, 10000);
            // если остаток от деления равен нулю, это бинарное число.
            if (N % 2 == 0)
            {
                Console.WriteLine($"{N}  Бинарное число.");
            }
            else
            {
                Console.WriteLine("Не бинарное.");
            }
            Console.ReadKey();
        }
    }
}
