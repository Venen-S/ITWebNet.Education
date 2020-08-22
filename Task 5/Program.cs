using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            long i, result = 1, num = 1;
            Console.WriteLine("Введите число");
            while (!long.TryParse(Console.ReadLine(), out i))
                Console.WriteLine("Некорректный ввод данных");
            Console.Write("Факториал {0} = ", i);
            do
            {
                result *= num;
                num++;
            } while (num <= i);
            Console.Write(result);
            Console.ReadKey();
        }
    }
}
