using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SolievAH.Sprint4.Task3.V6.Lib;

namespace Tyuiu.SolievAH.Sprint4.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Солиев А.Х. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерный статический массив                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Солиев А.Х. | СМАРТб-23-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 8.                          *");
            Console.WriteLine("*  Найдите максимальный элемент во второй строке массива.                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] array = new int[,] { { 8, 8, 3, 4, 5 },
                                            { 8, 6, 6, 4, 6 },
                                            { 3, 6, 5, 3, 4 },
                                            { 5, 6, 3, 7, 5 },
                                            { 7, 8, 5, 6, 6 } };

            Console.Write("Массив:{ ");
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                if (i != 0) { Console.Write("\t "); }
                Console.Write("{");
                for (int j = 0; j < array.Length / (array.GetUpperBound(0) + 1); j++)
                {
                    Console.Write(array[i, j]);
                    if (j != array.GetLength(0) - 1) { Console.Write(", "); }
                }
                Console.Write("}");
                if (i != array.GetLength(0) - 1) { Console.WriteLine(","); }
            }
            Console.WriteLine("}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
