using Tyuiu.YushkovaES.Sprint6.Task3.V1.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task3.V1.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                {25, 20, 28, 2, 6},
                {19, 9, 18, -7, 24},
                {21, 16, 5, -7, -8},
                {30, -13, 1, -15, 2},
                {31, 9, -3, -9, -18}
            };

            int[,] res = ds.Calculate(matrix);

            // Проверяем, что первый столбец отсортирован по возрастанию
            Assert.AreEqual(19, res[0, 0]); // минимальное в первом столбце: 19
            Assert.AreEqual(21, res[1, 0]); // второе: 21
            Assert.AreEqual(25, res[2, 0]); // третье: 25
            Assert.AreEqual(30, res[3, 0]); // четвертое: 30
            Assert.AreEqual(31, res[4, 0]); // пятое: 31

            // Проверяем, что строки перемещаются целиком
            // После сортировки строка с 19 должна быть первой
            Assert.AreEqual(9, res[0, 1]);  // второй элемент первой строки
            Assert.AreEqual(18, res[0, 2]); // третий элемент первой строки
            Assert.AreEqual(-7, res[0, 3]); // четвертый элемент первой строки
            Assert.AreEqual(24, res[0, 4]); // пятый элемент первой строки
        }

        [TestMethod]
        public void CheckAlreadySorted()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                {1, 2, 3},
                {2, 3, 4},
                {3, 4, 5}
            };

            int[,] res = ds.Calculate(matrix);

            // Матрица уже отсортирована
            Assert.AreEqual(1, res[0, 0]);
            Assert.AreEqual(2, res[1, 0]);
            Assert.AreEqual(3, res[2, 0]);
        }

        [TestMethod]
        public void CheckReverseSorted()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                {5, 1, 1},
                {4, 2, 2},
                {3, 3, 3},
                {2, 4, 4},
                {1, 5, 5}
            };

            int[,] res = ds.Calculate(matrix);

            // После сортировки должен быть отсортирован по возрастанию
            Assert.AreEqual(1, res[0, 0]);
            Assert.AreEqual(2, res[1, 0]);
            Assert.AreEqual(3, res[2, 0]);
            Assert.AreEqual(4, res[3, 0]);
            Assert.AreEqual(5, res[4, 0]);
        }
    }
}
