using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 12;
            int z = 3;

            int answer = OperationOne(x, y, z);
            Console.WriteLine(answer);

            answer = OperationTwo(x, y, z);
            Console.WriteLine(answer);

            answer = OperationThree(x, y, z);
            Console.WriteLine(answer);

            answer = OperationFour(x, y, z);
            Console.WriteLine(answer);

            answer = OperationFive(x, y, z);
            Console.WriteLine(answer);

            Console.ReadKey();
        }


        //Последовательность операций Будет указана в комментариях
        static int OperationOne(int x, int y, int z)
        {
            var result=x += y - x++ * z;
            
            //х++ но возвращается старое число (10)
            //10*3=30
            //10+12=22
            //22-30
            //Ответ -8
            return result;
        }

        static int OperationTwo(int x,int y,int z)
        {
            var result = z = --x - y * 5;
            //--х вернет новое число т.е. 9
            //12*5=60
            //9-60=-51
            //в z записываем -51
            //Ответ -51
            return result;
        }

        static int OperationThree(int x,int y,int z)
        {
            var result = y /= x + 5 % z;
            //5%3=2
            //10+2=12
            //12/12=1
            //в y записываем 1
            //Ответ 1
            return result;
        }

        static int OperationFour(int x,int y,int z)
        {
            var result = z = x++ + y * 5;
            //х++ но будет 10
            //12*5=60
            //10+60=70
            //В z записываем 70
            //Ответ 70
            return result;
        }

        static int OperationFive(int x, int y,int z)
        {
            var result = x = y - x++ * z;
            //z++ (10++) вернется 10
            //10*3=30
            //12-30=-18
            //Записываем в х -18
            //Ответ -18
            return result;
        }
    }
}
