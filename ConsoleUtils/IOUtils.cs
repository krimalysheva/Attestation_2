using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLogic;

namespace ConsoleUtils
{
    public class IOUtils
    {
        // Функция ввода значения с консоли в диалогом режиме:
        //   функции передается название значения (переменной) в виде строки (string),
        //   функция возвращает введенное значение типа T;
        //   (string) -> T
        public static T ReadValueFromConsole<T>(string varName)
        {
            while (true)
                try
                {
                    Console.Write("Введите {0}: ", varName);
                    return ConvertUtils.StrToValue<T>(Console.ReadLine());
                }
                catch { }  // "маскируем" ошибку (выполнится еще раз тело цикла)
        }


        // Функция ввода массива с консоли в диалогом режиме:
        //   функции передается название массива (переменной) в виде строки (string),
        //   функция возвращает введенное значение типа T[];
        //   (string) -> T[]
        public static T[] ReadArrayFromConsole<T>(string arrName)
        {
            while (true)
                try
                {
                    if (arrName != null)
                        Console.Write("Введите {0}: ", arrName);

                    return ConvertUtils.StrToArray<T>(Console.ReadLine());
                }
                catch { }  // "маскируем" ошибку (выполнится еще раз тело цикла)
        }


        public static T[,] ReadMatrixFromConsole<T>(string matrixName, int n, int m)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите {0}: ", matrixName);

                    T[,] matrix = new T[n, m];

                    for (int i = 0; i < n; i++)
                    {
                        T[] arr = ReadArrayFromConsole<T>(null);

                        if (arr.Length != m)
                            throw new Exception();

                        for (int j = 0; j < m; j++)
                        {
                            matrix[i, j] = arr[j];
                        }
                    }

                    return matrix;
                }
                catch (Exception e) {
                    Console.WriteLine("Во время ввода произошла ошибка");
                }
            }
        }

        public static T[,] ReadMatrixFromConsole<T>(string matrixName, bool square = false)
        {
            int n, m;

            if (square)
            {
                n = m = ReadValueFromConsole<int>("размерность массива");
            }
            else
            {
                n = ReadValueFromConsole<int>("высоту массива");
                m = ReadValueFromConsole<int>("ширину массива");
            }

            return ReadMatrixFromConsole<T>(matrixName, n, m);
        }
    }
}
