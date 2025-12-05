using Tyuiu.YushkovaES.Sprint6.Task5.V22.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            // Создаем тестовый файл
            string path = @"C:\testfile_Sprint6_Task5_V22.txt";
            string testData = "3.0 8.5 1.2 12.7 5.0 7.3 9.8 2.1 15.4 4.9 6.2 10.1 11.5 0.5 14.9 3.3 8.7 2.8 13.6 1.9 20.0 25.5";
            File.WriteAllText(path, testData);

            DataService ds = new DataService();

            // Получаем данные
            double[] result = ds.LoadFromDataFile(path);

            // Проверяем количество элементов (должно быть 20)
            Assert.AreEqual(20, result.Length);

            // Проверяем некоторые значения
            Assert.AreEqual(3.0, result[0], 0.001);
            Assert.AreEqual(8.5, result[1], 0.001);
            Assert.AreEqual(1.2, result[2], 0.001);

            // Очищаем тестовый файл
            File.Delete(path);
        }

        [TestMethod]
        public void ValidGetNumbersGreaterThanFive()
        {
            DataService ds = new DataService();

            // Тестовые данные
            double[] testArray = { 3.0, 8.5, 1.2, 12.7, 5.0, 7.3, 9.8, 2.1, 15.4, 4.9 };

            // Получаем результат
            double[] result = ds.GetNumbersGreaterThanFive(testArray);

            // Проверяем количество чисел > 5 (8.5, 12.7, 7.3, 9.8, 15.4)
            Assert.AreEqual(5, result.Length);

            // Проверяем конкретные значения
            Assert.AreEqual(8.5, result[0], 0.001);
            Assert.AreEqual(12.7, result[1], 0.001);
            Assert.AreEqual(7.3, result[2], 0.001);
            Assert.AreEqual(9.8, result[3], 0.001);
            Assert.AreEqual(15.4, result[4], 0.001);
        }

        [TestMethod]
        public void ValidRoundNumbers()
        {
            DataService ds = new DataService();

            // Тестовые данные
            double[] testArray = { 12.3456, 7.8912, 9.1234, 15.6789 };

            // Получаем результат с округлением до 3 знаков
            double[] result = ds.RoundNumbers(testArray, 3);

            // Проверяем количество элементов
            Assert.AreEqual(4, result.Length);

            // Проверяем округленные значения
            Assert.AreEqual(12.346, result[0], 0.001);
            Assert.AreEqual(7.891, result[1], 0.001);
            Assert.AreEqual(9.123, result[2], 0.001);
            Assert.AreEqual(15.679, result[3], 0.001);
        }

        [TestMethod]
        public void ValidConvertToIntArray()
        {
            DataService ds = new DataService();

            // Тестовые данные
            double[] testArray = { 12.7, 7.3, 9.8, 15.4 };

            // Конвертируем в int
            int[] result = ds.ConvertToIntArray(testArray);

            // Проверяем количество элементов
            Assert.AreEqual(4, result.Length);

            // Проверяем значения (дробная часть отбрасывается)
            Assert.AreEqual(12, result[0]);
            Assert.AreEqual(7, result[1]);
            Assert.AreEqual(9, result[2]);
            Assert.AreEqual(15, result[3]);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void InvalidFilePath()
        {
            DataService ds = new DataService();

            // Пытаемся загрузить несуществующий файл
            ds.LoadFromDataFile(@"C:\nonexistentfile.txt");
        }
    }
}
