using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите уровень зарплаты");
            int year, salary;
            double result;
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите стаж");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Размер премии:");
            if(year>0&year<=4)
            {
                result = salary * 0.10;
                Console.WriteLine(result);
            }
            else if (year>4&year<=9)
            {
                result = salary * 0.15;
                Console.WriteLine(result);
            }
            else if (year > 9 & year <= 14)
            {
                result = salary * 0.25;
                Console.WriteLine(result);
            }
            else if (year > 14 & year <= 19)
            {
                result = salary * 0.35;
                Console.WriteLine(result);
            }
            else if (year > 19 & year <= 24)
            {
                result = salary * 0.45;
                Console.WriteLine(result);
            }
            else if (year > 24)
            {
                result = salary * 0.5;
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
