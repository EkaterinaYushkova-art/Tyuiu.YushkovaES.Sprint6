using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YushkovaES.Sprint6.Task3.V1.Lib
{
    public class DataService : ISprint6Task3V1
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] resultMatrix = (int[,])matrix.Clone();

            // Создаем массив для сортировки первого столбца
            int[] firstColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                firstColumn[i] = resultMatrix[i, 0];
            }

            // Сортируем первый столбец пузырьком
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (firstColumn[j] > firstColumn[j + 1])
                    {
                        // Меняем местами только элементы первого столбца
                        int temp = firstColumn[j];
                        firstColumn[j] = firstColumn[j + 1];
                        firstColumn[j + 1] = temp;
                    }
                }
            }

            // Записываем отсортированный первый столбец обратно в матрицу
            for (int i = 0; i < rows; i++)
            {
                resultMatrix[i, 0] = firstColumn[i];
            }

            return resultMatrix;
        }
    }
}
