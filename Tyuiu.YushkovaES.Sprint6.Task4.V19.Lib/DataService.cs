using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YushkovaES.Sprint6.Task4.V19.Lib
{
    public class DataService : ISprint6Task4V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                // F(x) = (5x + 2.5) / (sin(x) - 2) + 2
                double denominator = Math.Sin(x) - 2;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 0.0001)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double numerator = 5 * x + 2.5;
                    double result = numerator / denominator + 2;
                    valueArray[count] = Math.Round(result, 2);
                }

                count++;
            }
            return valueArray;
        }

        public string SaveToFileData(int startValue, int stopValue, double[] valueArray)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V19.txt";

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine("Таблица значений функции:");
                writer.WriteLine("F(x) = (5x + 2.5) / (sin(x) - 2) + 2");
                writer.WriteLine($"Диапазон: [{startValue}; {stopValue}]");
                writer.WriteLine("Шаг: 1");
                writer.WriteLine();

                for (int i = 0; i < valueArray.Length; i++)
                {
                    int x = startValue + i;
                    writer.WriteLine($"f({x}) = {valueArray[i]}");
                }
            }

            return path;
        }
    }
}
