using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string y = String.Empty;
            Console.WriteLine("Введите число");
            while (!int.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Некорректный ввод данных");
            var res = PositiveNumber(x);
            Console.WriteLine(res);
            res = JustANumber(x);
            Console.WriteLine(res);
            res = DivisionWithoutRemainder(x);
            Console.WriteLine(res);

            //var result = SuperMethod(x);
            //Console.WriteLine(result.Item1);
            //Console.WriteLine(result.Item2);
            //Console.WriteLine(result.Item3);

            Console.ReadKey();
        }

        //По скольку использовать суперметоды является не очень
        //хорошей практикой, в методе Main будет закомментирован
        //вызов этого метода, а метод будет разбит на 3
        //Данный метод специально под требования условий задачи
        static (string, string, string) SuperMethod(int x)
        {
            //Проверка на положительность числа
            bool flag = true;
            string item1=String.Empty, item2=String.Empty, item3=String.Empty;
            var item=(item1, item2, item3);
            if (x == 1 || x > 1)
                item.item1 = "Число положительное";
            else item.item1 = "Число отрицательное или равно 0";

            //Проверка на простоту
            for (int i = 2; i <= x/2; i++)
            {
                if (x % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                item.item2 = "Число простое";
            else item.item2 = "Число не простое";

            //Проверка на деление (2,5,3,6,9) без остатка
            item.item3 = "Число делится без остатка на: \n";
            if (x % 2 == 0 || x % 5 == 0 || x % 3 == 0 || x % 6 == 0 || x % 9 == 0)
            {
                if (x % 2 == 0)
                {
                    item.item3 += "2\n";
                }
                if (x % 5 == 0)
                {
                    item.item3 += "5\n";
                }
                if (x % 3 == 0)
                {
                    item.item3 += "3\n";
                }
                if (x % 6 == 0)
                {
                    item.item3 += "6\n";
                }
                if (x % 9 == 0)
                {
                    item.item3 += "9\n";
                }
            }
            else item.item3 = "Число не делиться ни на одно число без остатка";
            return item;
        }

        /// <summary>
        /// Метод проверки числа на положительность
        /// </summary>
        static string PositiveNumber(int x)
        {
            string item = String.Empty;
            if (x == 1 || x > 1)
                item = "Число положительное";
            else item = "Число отрицательное или равно 0";
            return item;
        }

        /// <summary>
        /// Метод проверки числа на то что оно простое
        /// </summary>
        static string JustANumber(int x)
        {
            bool flag = true;
            string item = String.Empty;
            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
                item = "Число простое";
            else item = "Число не простое";
            return item;
        }


        /// <summary>
        /// Проверка числа на деление без остатка на 2,3,5,6,9
        /// </summary>
        static string DivisionWithoutRemainder(int x)
        {
            string item = "Число делиться без остатка на: \n";
            if (x % 2 == 0 || x % 5 == 0 || x % 3 == 0 || x % 6 == 0 || x % 9 == 0)
            {
                if (x % 2 == 0)
                {
                    item += "2\n";
                }
                if (x % 5 == 0)
                {
                    item += "5\n";
                }
                if (x % 3 == 0)
                {
                    item += "3\n";
                }
                if (x % 6 == 0)
                {
                    item += "6\n";
                }
                if (x % 9 == 0)
                {
                    item += "9\n";
                }
            }
            else item = "Число не делиться ни на одно число без остатка";
            return item;
        }
    }
}
