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

            // ОЖИДАЕМЫЙ РЕЗУЛЬТАТ:
            // [[19,20,28,2,6],
            //  [21,9,18,-7,24],
            //  [25,16,5,-7,-8],
            //  [30,-13,1,-15,2],
            //  [31,9,-3,-9,-18]]

            // Проверяем первый столбец (должен быть отсортирован)
            Assert.AreEqual(19, res[0, 0]); // минимальное: 19
            Assert.AreEqual(21, res[1, 0]); // второе: 21  
            Assert.AreEqual(25, res[2, 0]); // третье: 25
            Assert.AreEqual(30, res[3, 0]); // четвертое: 30
            Assert.AreEqual(31, res[4, 0]); // пятое: 31

            // Проверяем, что остальные элементы НЕ изменились
            // Первая строка: была [25,20,28,2,6], стала [19,20,28,2,6]
            Assert.AreEqual(20, res[0, 1]); // остался 20
            Assert.AreEqual(28, res[0, 2]); // остался 28
            Assert.AreEqual(2, res[0, 3]);  // остался 2
            Assert.AreEqual(6, res[0, 4]);  // остался 6

            // Вторая строка: была [19,9,18,-7,24], стала [21,9,18,-7,24]
            Assert.AreEqual(9, res[1, 1]);  // остался 9
            Assert.AreEqual(18, res[1, 2]); // остался 18
            Assert.AreEqual(-7, res[1, 3]); // остался -7
            Assert.AreEqual(24, res[1, 4]); // остался 24
        }

        [TestMethod]
        public void CheckOnlyFirstColumnSorted()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                {5, 1, 1},
                {3, 2, 2},
                {4, 3, 3},
                {1, 4, 4},
                {2, 5, 5}
            };

            int[,] res = ds.Calculate(matrix);

            // Проверяем, что первый столбец отсортирован
            Assert.AreEqual(1, res[0, 0]);
            Assert.AreEqual(2, res[1, 0]);
            Assert.AreEqual(3, res[2, 0]);
            Assert.AreEqual(4, res[3, 0]);
            Assert.AreEqual(5, res[4, 0]);

            // Проверяем, что остальные столбцы не изменились
            Assert.AreEqual(1, res[0, 1]);
            Assert.AreEqual(2, res[1, 1]);
            Assert.AreEqual(3, res[2, 1]);
            Assert.AreEqual(4, res[3, 1]);
            Assert.AreEqual(5, res[4, 1]);
        }
    }
}
