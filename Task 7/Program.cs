using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите целое число больше 0");
            while(!Int32.TryParse(Console.ReadLine(),out x) && x>0)
                Console.WriteLine("Некорректный ввод данных");

            int result = Factorial(x);
            Console.WriteLine("Факториал числа {0} равен {1}", x, result);

            Console.ReadKey();
        }

        static int Factorial(int a)
        {
            if (a == 1)
                return 1;
            return a * Factorial(a - 1);
        }
    }
}
