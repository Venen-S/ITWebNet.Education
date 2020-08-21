using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, result;
            string oper = string.Empty;
            Console.WriteLine("Введите первое целое число: ");
            while(!int.TryParse(Console.ReadLine(), out x)||x == 0)
                Console.WriteLine("Число должно быть целым и не равно 0");
            
            Console.WriteLine("Введите второе целое число");
            while (!int.TryParse(Console.ReadLine(), out y) || y == 0)
                Console.WriteLine("Число должно быть целым и не равно 0");

            Console.WriteLine("Выберите арифметическую операцию \n" +
                "* - для умножения\n" +
                "/ - для деления \n" +
                "+ - для сложения \n" +
                "- - для вычетания");
            oper = Console.ReadLine();

            result = SwitchOperation(oper, x, y);

            Console.WriteLine("Ответ: {0}", result);
            Console.ReadKey();
        }

        static int SwitchOperation(string oper, int a, int b)
        {
            int result = 0;
            switch (oper)
            {
                case "*":
                    result = Multiplication(a, b);
                    break;
                case "/":
                    result = Division(a, b);
                    break;
                case "+":
                    result = Addition(a, b);
                    break;
                case "-":
                    result = Substraction(a, b);
                    break;
            }
            return result;
        }

        #region арифметические операции

        /// <summary>
        /// Сложение
        /// </summary>
        static int Multiplication(int a, int b)
        {
            var result = a * b;
            return result;
        }

        /// <summary>
        /// Деление
        /// </summary>
        static int Division(int a,int b)
        {
            var result = a / b;
            return result;
        }

        /// <summary>
        /// Сложение
        /// </summary>
        static int Addition(int a, int b)
        {
            var result = a + b;
            return result;
        }

        /// <summary>
        /// Вычитание
        /// </summary>
        static int Substraction(int a, int b)
        {
            var result = a - b;
            return result;
        }

        #endregion
    }
}
