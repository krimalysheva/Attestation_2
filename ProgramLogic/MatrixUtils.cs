using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramLogic
{

    public class MatrixUtils<T>
    {
        public T[,] Matrix { get; set; }

        public MatrixUtils(T[,] matrix)
        {
            this.Matrix = matrix;
        }

        public int[,] GetFriendlyElementsCountArray()
        {
            int rowsCount = Matrix.GetLength(0);
            int columnsCount = Matrix.GetLength(1);

            int[,] friendlyElementsCountArray = new int[Matrix.GetLength(0), Matrix.GetLength(1)];

            // Заполняем массив значением -1, т.е. неизвестным количеством
            // дружественных элементов
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    friendlyElementsCountArray[i, j] = -1;
                }
            }

            // Проходимся по массиву и ищем количество дружественных элементов
            // для каждого элемента
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    if (friendlyElementsCountArray[i, j] != -1)
                        continue;

                    List<Tuple<int, int>> indexes = new List<Tuple<int, int>>();

                    int count = GetFriendlyElementsCount(-1, -1, i, j, indexes);

                    foreach (Tuple<int, int> index in indexes)
                    {
                        friendlyElementsCountArray[index.Item1, index.Item2] = count - 1;
                    }
                }
            }

            return friendlyElementsCountArray;
        }

        // Возвращает количество дружественных элементов массива
        // для элемента на позиции [i, j]
        public int GetFriendlyElementsCount(int fromI, int fromJ, int i, int j, List<Tuple<int, int>> indexes)
        {
            // Если вышли за пределы массива, то возвращаем ноль
            if (i < 0 || i >= Matrix.GetLength(0) || j < 0 || j >= Matrix.GetLength(1))
                return 0;

            // Если уже проверяли этот элемент, то возвращаем ноль
            if (indexes.Contains(new Tuple<int, int>(i, j)))
                return 0;

            // Если значения элементов не равны, то попали на недружественный элемент
            // и возвращаем ноль
            if (fromI != -1 && fromJ != -1 && Comparer<T>.Default.Compare(Matrix[fromI, fromJ], Matrix[i, j]) != 0)
                return 0;

            // Если данный элемент является дружественным для предыдущего, то пометим его
            // и вернем количество дружественных элементов для текущего плюс 1
            indexes.Add(new Tuple<int, int>(i, j));

            int count = 1;

            // Выше
            count += GetFriendlyElementsCount(i, j, i - 1, j, indexes);
            // Ниже
            count += GetFriendlyElementsCount(i, j, i + 1, j, indexes);
            // Левее
            count += GetFriendlyElementsCount(i, j, i, j - 1, indexes);
            // Правее
            count += GetFriendlyElementsCount(i, j, i, j + 1, indexes);

            return count;
        }

        public List<Tuple<int, int>> GetEvenElementsWithOddIndexesSum()
        {
            List<Tuple<int, int>> result = new List<Tuple<int, int>>();

            int rowsCount = Matrix.GetLength(0);
            int columnsCount = Matrix.GetLength(1);

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    if (Convert.ToInt32(Matrix[i, j]) % 2 == 0 && (i + j) % 2 == 1)
                    {
                        result.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            return result;
        }
    }
}
