using Tyuiu.YushkovaES.Sprint6.Task4.V19.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);

            // Проверяем количество элементов (11: от -5 до 5 включительно)
            Assert.AreEqual(11, res.Length);

            // Проверяем некоторые значения
            // При x = -5: (5*(-5) + 2.5) / (sin(-5) - 2) + 2
            // sin(-5) ≈ 0.95892
            // (-25 + 2.5) / (0.95892 - 2) + 2 = -22.5 / (-1.04108) + 2 ≈ 21.61 + 2 = 23.61
            Assert.AreEqual(23.61, res[0]);

            // При x = 0: (0 + 2.5) / (0 - 2) + 2 = 2.5 / (-2) + 2 = -1.25 + 2 = 0.75
            Assert.AreEqual(0.75, res[5]);

            // Проверяем, что нет NaN или Infinity
            foreach (double value in res)
            {
                Assert.IsFalse(double.IsNaN(value));
                Assert.IsFalse(double.IsInfinity(value));
            }
        }

        [TestMethod]
        public void ValidSaveToFileData()
        {
            DataService ds = new DataService();

            int startValue = -2;
            int stopValue = 2;
            double[] valueArray = ds.GetMassFunction(startValue, stopValue);

            string path = ds.SaveToFileData(startValue, stopValue, valueArray);

            // Проверяем что файл создан
            Assert.IsTrue(File.Exists(path));

            // Проверяем содержимое файла
            string[] lines = File.ReadAllLines(path);
            Assert.IsTrue(lines.Length >= 5);
            Assert.IsTrue(lines[0].Contains("Таблица значений функции"));

            // Удаляем временный файл
            File.Delete(path);
        }
    }
}
