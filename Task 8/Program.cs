using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //index переменная которая обрезает массив с начала
            //count переменная которая обрезает массив с конца
            //Можно подставить оюбое значение на выбор
            int index = 20, count = 80;
            int[] mas = new int[100];
            mas = RandomMas(mas);
            Console.WriteLine("Массив после рандомизации: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]+" ");
            }

            mas = ArraySort(mas);
            Console.WriteLine("Массив после сортировки: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]+" ");
            }

            mas = MyReverse(mas);
            Console.WriteLine("Массив после иверсии:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]+" ");
            }

            var newMas=SubArray(mas, index, count);
            Console.WriteLine("Массив после укорочения:");
            for (int i = 0; i < newMas.Length; i++)
            {
                Console.Write(newMas[i]+" ");
            }
            
        }

        //Заполняем массив случайными числами
        static int[] RandomMas(int[] mas)
        {
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(0, 100);
            }
            return mas;
        }

        //Сортируем массив от наименьшего к наибольшему
        static int[] ArraySort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length; j++)
                {
                    if(mas[i]<mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }

        //Инверсия массива
        static int[] MyReverse(int[] mas)
        {
            int temp;
            int len = mas.Length;
            for (int i = 0; i < len/2; i++)
            {
                temp = mas[i];
                mas[i] = mas[len - i - 1];
                mas[len - i - 1] = temp;
            }
            return mas;
        }

        //Получение фрагмента массива от index до count
        static int[] SubArray(int[] mas, int index, int count)
        {
            int[] temp =new int[mas.Length - count];
            int[] newTemp =new int[mas.Length-index-temp.Length];
            int[] newMas = new int[newTemp.Length];
            for (int i = 0; i < newMas.Length; i++)
            {
                newMas[i] = mas[i+index];
            }
            return newMas;
        }
    }
}
