using System;
using ProgramLogic;
using ConsoleUtils;

namespace _20._9._20_Console
{
    class Program
    {
        //Скинуть в отдельную библиотеку

        //Считывание из файла
       /* static int[,] ReadMatrixFromFileOrConsole()
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
        */
        static int Main(string[] args)
        {
            //Создаем матрицу и записываем в нее результат  - Считывания из файла (или из консоли)
            int[,] matrix = ConsoleMatrix.ReadMatrixFromFileOrConsole();

            //Объект utils, который является подопотным для класса MatrixUtils
            MatrixUtils<int> utils = new MatrixUtils<int>(matrix);

            //Выводим ответ
            string answer = "Индексы: " + Environment.NewLine;

            //нам просто необходимо перебрать все элементы Матрицы в объекте utils с помощью метода GetEvenElementsWithOddIndexesSum
            foreach (Tuple<int, int> indexes in utils.GetEvenElementsWithOddIndexesSum())
            {
                //записываем ответ в строку данного формата
                answer += String.Format("[{0}, {1}], ", indexes.Item1, indexes.Item2); //запись объектов кортажа
            }

            //Возвращает новую строку, в которой были удалены все символы, начиная с указанной позиции и до конца в текущем экземпляре.
            answer = answer.Remove(answer.Length - 2);

            Console.WriteLine("Результат:");
            Console.WriteLine(answer);

            Console.Write("Сохранить результат в файл (да/нет): ");

            //Сохраниение ответа пользователя
            string writeToFile = Console.ReadLine();

            if (writeToFile == "да")
            {
                //Сохранить в файл все-таки 
                ConsoleMatrix.SaveAnswerToFile(matrix, answer);
            }

            return 0;
        }
    }
}
