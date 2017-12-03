using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
        public class MatrixUtils<T>
        {
            public T[,] Matrix { get; set; }

            public MatrixUtils(T[,] matrix)
            {
                this.Matrix = matrix;
            }
            //Вернуть индекс четных элементов, имеющих нечетную сумму индексов
            // Tuple  - кортеж. Могут комбинировать объекты различных типов. Проще в записи, чем массив
            public List<Tuple<int, int>> GetEvenElementsWithOddIndexesSum()
            {
                //Объявили новый результирующий список, чтобы не менять свойства матрицы
                List<Tuple<int, int>> result = new List<Tuple<int, int>>();

                //GetLength принимает целое число, которое определяет размер массива, 
                //который вы запрашиваете, и возвращает его длину.
                int rowsCount = Matrix.GetLength(0); //возвращает количество элементов в первом измерении Matrix - кол-во элементов в строке.
                int columnsCount = Matrix.GetLength(1);//возвращает количество элементов во втором измерении Matrix - кол-во элементов в столбце

                for (int i = 0; i < rowsCount; i++)
                {
                    for (int j = 0; j < columnsCount; j++)
                    {
                        //Сonvert.ToInt32(String) - 
                        //Преобразует заданное строковое представление числа в эквивалентное 32-битовое целое число со знаком.
                        if (Convert.ToInt32(Matrix[i, j]) % 2 == 0 && (i + j) % 2 == 1)
                        {
                            //Добавляет объект в конец списка List<T>.
                            //Записываем парные индексы полседовательно друг за другом
                            result.Add(new Tuple<int, int>(i, j));
                        }
                    }
                }

                return result;
            }
        }
    }
