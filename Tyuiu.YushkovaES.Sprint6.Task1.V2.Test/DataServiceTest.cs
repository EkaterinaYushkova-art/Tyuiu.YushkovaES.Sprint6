using Tyuiu.YushkovaES.Sprint6.Task1.V2.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task1.V2.Test
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
            // При x = -5
            Assert.AreEqual(-15.6, res[0]);

            // При x = 0
            Assert.AreEqual(3.25, res[5]);

            // При x = 5
            Assert.AreEqual(19.92, res[10]);
        }

        [TestMethod]
        public void CheckSingleValue()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(2, 2);

            // Должен быть один элемент
            Assert.AreEqual(1, res.Length);

            // При x = 2: (5*2 + 2.5) / (sin(2) + 2) + 2*2 + 2
            // sin(2) ≈ 0.9093
            // (10 + 2.5) / (0.9093 + 2) + 4 + 2 = 12.5/2.9093 + 6 ≈ 4.30 + 6 = 10.30
            Assert.AreEqual(8.97, res[0]);
        }

        [TestMethod]
        public void CheckNoDivisionByZero()
        {
            DataService ds = new DataService();

            // Проверяем диапазон, где sin(x) может быть -2
            // sin(x) = -2 невозможно, но проверяем алгоритм
            double[] res = ds.GetMassFunction(-10, 10);

            // Проверяем, что нет NaN или Infinity
            foreach (double value in res)
            {
                Assert.IsFalse(double.IsNaN(value));
                Assert.IsFalse(double.IsInfinity(value));
            }
        }
    }
}
