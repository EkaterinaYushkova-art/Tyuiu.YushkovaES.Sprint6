using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YushkovaES.Sprint6.Task2.V12.Lib
{
    public class DataService : ISprint6Task2V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] res = new double[len];
            int cnt = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 0.000000001) // небольшая погрешность для double
                {
                    res[cnt] = 0;
                }
                else
                {
                    double y = (2.0 * x + 6.0) / denominator - 3.0;
                    y = Math.Round(y, 2);
                    res[cnt] = y;
                }

                cnt++;
            }

            return res;


        }
    }
}
