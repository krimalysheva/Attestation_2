using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public enum ChangeSeriaLengthMode
    {
        Increase, Decrease
    }

    public class ArrayTransformatorUtils
    {
        public int[] Arr;

        public ArrayTransformatorUtils(int[] sourceArr)
        {
            this.Arr = sourceArr;
        }

        public int[] ChangeSeriasLength(ChangeSeriaLengthMode mode)
        {
            int resultArrayLength = (mode == ChangeSeriaLengthMode.Increase) ? Arr.Length + Arr.Length / 2 : Arr.Length;
            int[] resultArr = new int[resultArrayLength];
            int freeIndex = 0;

            int currentSeriaLength = 1;

            for (int i = 0; i < Arr.Length; i++)
            {
                bool isSeriaContinues = (i > 0 && Arr[i] == Arr[i - 1]);

                if (isSeriaContinues)
                {
                    // Если серия продолжается
                    currentSeriaLength++;
                }

                // Проверяем, что серия кончилась или оказались на последнем элементе
                if (!isSeriaContinues || i == Arr.Length - 1)
                {
                    if (currentSeriaLength > 1)
                    {
                        if (mode == ChangeSeriaLengthMode.Increase)
                        {
                            resultArr[freeIndex++] = Arr[i - 1];
                        }
                        else
                        {
                            freeIndex--;
                        }
                    }

                    currentSeriaLength = 1;
                }

                resultArr[freeIndex++] = Arr[i];
            }

            return resultArr.Take(freeIndex).ToArray();
        }
        public void FindSubMaxSequence(out int maxLength, out int firstIndex)
        {
            maxLength = 1; //если массив пустой, то брось исключение
            firstIndex = 0;
            for (int center = 1; center < Arr.Length * 2 - 1; center++)
            {
                int length = 0;
                int l; //левая граница 
                int r; //правая граница
                if (center % 2 == 0)
                {
                    l = center / 2 - 1;
                    r = center / 2 + 1;
                }
                else
                {
                    l = (center - 1) / 2;
                    r = (center + 1) / 2;
                }
                int distance = 0; //размах между цифрами полсе двух if-ов равен 1
                while (l >= 0 && r < Arr.Length && Arr[l] == Arr[r]) //
                {
                    distance++;
                    l--;
                    r++;
                }

                length = 2 * distance + (1 - center % 2); //четное - (+1); нечетное - (-1)
                if (length > maxLength)
                {
                    firstIndex = center / 2 - distance + center % 2;
                    maxLength = length;
                }
            }
        }
    }

}
