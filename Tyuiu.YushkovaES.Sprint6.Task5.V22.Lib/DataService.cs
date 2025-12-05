using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YushkovaES.Sprint6.Task5.V22.Lib
{
    public class DataService : ISprint6Task5V22
    {
        public double[] LoadFromDataFile(string path)
        {
            string fileData = File.ReadAllText(path);

            // Разделяем по пробелам и преобразуем в числа
            List<double> numbers = new List<double>();
            string[] strNumbers = fileData.Split(new[] { ' ', '\t', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            // Берем максимум 20 чисел
            int count = Math.Min(strNumbers.Length, 20);

            for (int i = 0; i < count; i++)
            {
                if (double.TryParse(strNumbers[i], out double number))
                {
                    numbers.Add(number);
                }
            }

            return numbers.ToArray();
        }

        public double[] GetNumbersGreaterThanFive(double[] numbers)
        {
            if (numbers == null)
            {
                return new double[0];
            }

            List<double> result = new List<double>();
            foreach (double num in numbers)
            {
                if (num > 5)
                {
                    result.Add(num);
                }
            }
            return result.ToArray();
        }

        public double[] RoundNumbers(double[] numbers, int decimals = 3)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return new double[0];
            }

            double[] result = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = Math.Round(numbers[i], decimals, MidpointRounding.AwayFromZero);
            }
            return result;
        }

        // Метод для получения целых чисел (если нужно)
        public int[] ConvertToIntArray(double[] numbers)
        {
            if (numbers == null)
            {
                return new int[0];
            }

            int[] result = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = (int)numbers[i];
            }
            return result;
        }
    }
}
