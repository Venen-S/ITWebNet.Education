using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6, y = 10, z = 15;
            int result;

            result = OperationOne(x, y, z);
            Console.WriteLine(result);

            result = OperationTwo(x, y, z);
            Console.WriteLine(result);

            result = OperationThree(x, y, z);
            Console.WriteLine(result);

            result = OperationFour(x, y, z);
            Console.WriteLine(result);

            result = OperationFive(x, y, z);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static int OperationOne(int a, int b, int c)
        {
            var result = a += b >> a++ * c;
            ///6++=6
            ///6*15=90
            ///6+0=6
            return result;
        }
        static int OperationTwo(int a, int b, int c)
        {
            var result = c = ++a & b * 5;
            ///++6=7
            ///10*5=50
            ///7&50=2
            return result;
        }
        static int OperationThree(int a, int b, int c)
        {
            var result = b /= a + 5 | c;
            ///6+5=11
            ///11|15=15
            ///10/15=0
            return result;
        }
        static int OperationFour(int a, int b, int c)
        {
            var result = c = a++ & b * 5;
            ///6++=6
            ///10*5=50
            ///6&50=2
            return result;
        }
        static int OperationFive(int a, int b, int c)
        {
            var result = a = b << a++ ^ c;
            ///6++=6
            ///10<<6=640
            ///640^15=655
            return result;
        }
    }
}
