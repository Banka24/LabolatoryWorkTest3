using System.Collections.Generic;
using System.Linq;

namespace MyLib
{
    public static class Lab3
    {
        public static int OddDigits(int number)
        {
            var numbers = new List<int>();

            while (number > 0)
            {
                numbers.Add(number % 10);
                number /= 10;
            }

            return numbers.Count == 0 ? 0 : numbers.Count(i => i % 2 != 0);
        }

        public static string FormatPhoneNumber(string numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers)) return "Вы ввели пустую строку";

            if (numbers.Length != 10 || !numbers.All(char.IsDigit)) return "Вы ввели некорректный номер";

            return $"+1({numbers.Substring(0, 3)}){numbers.Substring(3, 3)}-{numbers.Substring(6)}";//(отрезаем первые 3 цифры)отрезаем 3 цифры - отрезаем 4 цифры
        }

        public static double GetTime(int k, int m, int n) => n * 1.0 / k * m * 2;
    }
}
