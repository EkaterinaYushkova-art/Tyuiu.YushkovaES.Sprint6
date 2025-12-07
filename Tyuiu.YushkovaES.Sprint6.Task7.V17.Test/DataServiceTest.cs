using Tyuiu.YushkovaES.Sprint6.Task7.V17.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            // Создаем тестовый CSV файл
            string testPath = @"C:\Users\user\source\repos\Tyuiu.YushkovaES.Sprint6\спринт6\InPutDataFileTask7V17.csv";
            string testData = "1;2;3;4\n5;6;7;8\n9;10;11;12";
            File.WriteAllText(testPath, testData.Replace('\n', '\r'));

            // Получаем результат
            int[,] result = ds.GetMatrix(testPath);

            // Ожидаемая матрица: во второй строке четные числа заменены на 4
            // Исходная:     Результат:
            // 1  2  3  4    1  2  3  4
            // 5  6  7  8    5  4  7  4    <-- вторая строка
            // 9 10 11 12    9 10 11 12

            // Проверяем размеры
            Assert.AreEqual(3, result.GetLength(0), "Неверное количество строк");
            Assert.AreEqual(4, result.GetLength(1), "Неверное количество столбцов");

            // Проверяем вторую строку (индекс 1)
            Assert.AreEqual(5, result[1, 0], "Элемент [1,0] неверный");
            Assert.AreEqual(4, result[1, 1], "Элемент [1,1] должен быть 4 (четное -> 4)");
            Assert.AreEqual(7, result[1, 2], "Элемент [1,2] неверный");
            Assert.AreEqual(4, result[1, 3], "Элемент [1,3] должен быть 4 (четное -> 4)");

            // Проверяем, что другие строки не изменились
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(2, result[0, 1]);
            Assert.AreEqual(3, result[0, 2]);
            Assert.AreEqual(4, result[0, 3]);

            Assert.AreEqual(9, result[2, 0]);
            Assert.AreEqual(10, result[2, 1]);
            Assert.AreEqual(11, result[2, 2]);
            Assert.AreEqual(12, result[2, 3]);
        }

        [TestMethod]
        public void TestSaveMatrixToFile()
        {
            DataService ds = new DataService();

            // Создаем тестовую матрицу
            int[,] testMatrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

            string savePath = @"test_output.csv";

            // Сохраняем матрицу
            ds.SaveMatrixToFile(testMatrix, savePath);

            // Проверяем, что файл создан
            Assert.IsTrue(File.Exists(savePath), "Файл не был создан");

            // Читаем файл и проверяем содержимое
            string[] lines = File.ReadAllLines(savePath);
            Assert.AreEqual("1;2;3", lines[0], "Первая строка неверная");
            Assert.AreEqual("4;5;6", lines[1], "Вторая строка неверная");
            Assert.AreEqual("7;8;9", lines[2], "Третья строка неверная");

            // Удаляем тестовый файл
            File.Delete(savePath);
        }

    }
}

