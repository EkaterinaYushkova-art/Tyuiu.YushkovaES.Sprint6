using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YushkovaES.Sprint6.Task1.V2.Lib
{
    public class DataService : ISprint6Task1V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                // F(x) = (5x + 2.5) / (sin(x) + 2) + 2x + 2
                double denominator = Math.Sin(x) + 2;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 0.0001)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double numerator = 5 * x + 2.5;
                    double fraction = numerator / denominator;
                    double result = fraction + 2 * x + 2;
                    valueArray[count] = Math.Round(result, 2);
                }

                count++;
            }
            return valueArray;
        }
    }
}
