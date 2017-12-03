using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLogic;

namespace ConsoleUtils
{
    public class ConsoleMatrix
    {
        //Считывание из файла
       public static int[,] ReadMatrixFromFileOrConsole()
        {
            //Задаем  вопрос пользователю:
            Console.Write("Считать из файла (да/нет): ");
            //Создаем строку, в которую будет считываться ответ пользователя
            string readAnswer = Console.ReadLine();

            int[,] matrix;
            //Если считывание из матрицы, то:
            if (readAnswer == "да")
            {
                while (true)
                {
                    try
                    {
                        //Просим пользователя написать путь к файлу - т.е. указать документ, с которым нам предстоит работать
                        Console.Write("Введите путь к входному файлу: ");

                        //Записываем ответ пользователя
                        string inFileName = Console.ReadLine();

                        //Читаем документ (что в виде строки)
                        string matrixText = FileUtils.ReadStringFromFile(inFileName);

                        //А теперь этот документ конвертируем в матрицу
                        matrix = ConvertUtils.ConvertStrToMatrix(matrixText);

                        //Получаем готовое решение
                        return matrix;
                    }
                    catch (Exception e)
                    {
                        // Если во время считывания из файла ошибка, то просим ввести путь ещё раз
                        Console.WriteLine("Невозможно считать из этого файла");
                    }
                }
            }
            //Если пользователь решил считать цифры с консоли: 
            else
            {
                //Функция ввода значения с консоли в диалогом режиме:
                // string - <T>
                matrix = IOUtils.ReadMatrixFromConsole<int>("массив чисел", true);
            }

            //Возвращаем результат 
            return matrix;
        }

        //Сохранение в файл
        public static void SaveAnswerToFile(int[,] matrix, string answer)
        {
            //Пока верное условие, иначе, выведем ошибку и с нажатием Enter действие продолжиться заново
            while (true)
            {
                try
                {
                    //Просим вывести пуьт:
                    Console.Write("Введите путь к выходному файлу: ");
                    //Считыввем ответ пользоваетеля
                    string outFileName = Console.ReadLine();

                    //Записываем результат 
                    FileUtils.WriteStringToFile(outFileName, answer);
                    return;
                }
                catch (Exception e)
                {
                    // Если во время считывания из файла ошибка, то просим ввести путь ещё раз
                    Console.WriteLine("Невозможно записать в этот файл");
                }
            }
        }

    }
}
