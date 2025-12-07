using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YushkovaES.Sprint6.Task7.V17.Lib
{
    public class DataService : ISprint6Task7V17
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            // Определяем размерность матрицы
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            // Заполняем матрицу
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            // Изменяем ВТОРУЮ строку (индекс 1): четные числа заменяем на 4
            int rowIndex = 1; // Вторая строка (индексация с 0)

            if (rowIndex < rows)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[rowIndex, j] % 2 == 0) // Если число четное
                    {
                        matrix[rowIndex, j] = 4;
                    }
                }
            }

            return matrix;
        }

        // Метод для сохранения матрицы в файл
        public void SaveMatrixToFile(int[,] matrix, string path)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < rows; i++)
                {
                    string[] rowValues = new string[columns];
                    for (int j = 0; j < columns; j++)
                    {
                        rowValues[j] = matrix[i, j].ToString();
                    }
                    writer.WriteLine(string.Join(";", rowValues));
                }

            }
        }
    }
}
