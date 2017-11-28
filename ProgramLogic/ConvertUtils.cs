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
            return new List<T> (Array.ConvertAll(
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
    }
}
