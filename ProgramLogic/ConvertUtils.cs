using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramLogic
{
    public class ConvertUtils
    {
        // Функция конвертирует строку в значение T
        // (при невозможности конвертации происходит ошибка)
        public static T StrToValue<T>(string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }

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
                    return StrToValue<T>(Console.ReadLine());
                }
                catch { }  // "маскируем" ошибку (выполнится еще раз тело цикла)
        }

        // Функция конвертирует строку в массив элементов T
        // (при невозможности конвертации происходит ошибка)
        public static T[] StrToArray<T>(string str)
        {
            return Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            );
        }

        //For Lists
        public static List<T> StrToList<T>(string str)
        {
            return new List<T>(Array.ConvertAll(
                str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (s) => StrToValue<T>(s)
            ));
        }

        // Функция конвертирует массив элементов T в строку
        // (вторым параметром можно указать разделитель, по умолчанию ", ")
        public static string ArrayToStr<T>(T[] arr, string separator = ", ")
        {
            return arr == null ? "null" : String.Join(separator, arr);
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
                    Console.Write("Введите {0}: ", arrName);
                    return StrToArray<T>(Console.ReadLine());
                }
                catch { }  // "маскируем" ошибку (выполнится еще раз тело цикла)
        }

        // Вывод массива в консоль
        public static void PrintArray<T>(string message, T[] array)
        {
            Console.Write(message);
            Console.WriteLine(ArrayToStr(array));
        }

        // Функция конвертирует список элементов T в строку
        // (вторым параметром можно указать разделитель, по умолчанию ", ")
        public static string ListToStr<T>(List<T> list, string separator = ", ")
        {
            return list.Count == 0 ? "null" : string.Join(separator, list.ToArray());
        }

        //конертировать матрицу в строку
        public static string ConvertMatrixToStr(int[,] matrix)
        {
            string result = "";
            int rowsCount = matrix.GetLength(0); //получить длину соответ. измерений
            int columnsCount = matrix.GetLength(1);

            for (int row = 0; row < rowsCount; row++)
            {
                string newLine = "";

                for (int column = 0; column < columnsCount; column++)
                {
                    newLine += matrix[row, column];

                    if (column != columnsCount - 1)
                    {
                        newLine += " ";
                    }
                }
                result += newLine;

                if (row != rowsCount - 1)
                {
                    newLine += " ";
                }

            }
            return result;
        }
        //конертировать строку в матрицу
        public static int[,] ConvertStrToMatrix(string str)
        {
            string[] rows = str.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries); //делим string на строки

            if (rows.Length == 0) //если размер массива 
                throw new ArgumentException();

            string[] firstRowColumns = rows[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //делим строки на элементы

            if (firstRowColumns.Length == 0)
                throw new ArgumentException();

            int rowsCount = rows.Length; //получить длину соответ. измерений
            int columnsCount = firstRowColumns.Length;

            int[,] result = new int[rowsCount, columnsCount];

            for (int row = 0; row < rowsCount; row++)
            {
                string[] cells = rows[row].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //делим строки на элементы

                for (int column = 0; column < cells.Length; column++)
                {
                    result[row, column] = int.Parse(cells[column]);
                }

            }

            return result;
        }
    }
}

