using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class Calculator
    {
        // Поле для хранения значения x
        public double x;

        // Конструктор класса (принимает значение x)
        public Calculator(double functionArg)
        {
            if (Math.Abs(functionArg) >= 1)
            {
                // В случае ошибки бросаем исключение
                throw new Exception("Значение x не входит в допустимый диапазон");
            }

            // Присваиваем полю "x" значение параметра functionArg
            this.x = functionArg;
        }

        // Название метода должно быть глаголом
        // Метод для прямого вычисления значения функции
        public double CalculateFunctionDirectly()
        {
            return 1 / Math.Pow(1 - x, 2);
        }

        // Метод для приближенного вычисления значения функции
        // n - число слагаемых, e - минимальная величина слагаемого по модулю
        public double CalculateFunctionApproximately(int n, double minAddendValue)
        {
            if (n < 1)
            {
                throw new Exception("Передано некорректное число слагаемых");
            }

            double sum = 1;
            double addend = 1; // переменная для хранения слагаемого

            for (int i = 1; i < n; i++)
            {
                addend *= (double)(i + 1) / i * x;

                if (Math.Abs(addend) > minAddendValue)
                {
                    sum += addend;
                }
            }

            return sum;
        }
    }
}
