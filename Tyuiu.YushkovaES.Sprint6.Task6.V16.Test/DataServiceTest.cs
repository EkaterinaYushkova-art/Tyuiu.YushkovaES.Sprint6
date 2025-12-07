using System.Text;
using Tyuiu.YushkovaES.Sprint6.Task6.V16.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();

            // Создаем тестовый файл с известным содержимым
            string testPath = @"InPutFileTask6V16.txt";

            // Записываем тестовые данные в файл
            string testData = @"UPPfdzU ulzPXa UpGwjzkBH xvfsWpk
BYiySs S OHcr NsMnNzS Y KgepHrKCHa
BXGdYDF brIBPtX vatYxkk gLertvwzs
KyiidnDo FVUh XNQBU sMLuPzlvneiTo
XIpph QN hZznJL bWk Rz tfouGdncXlJ";

            // Явно указываем кодировку UTF8 при записи
            File.WriteAllText(testPath, testData, Encoding.UTF8);

            // Ожидаемый результат - слова с 'b' или 'B'
            string expected = "UpGwjzkBH BYiySs BXGdYDF brIBPtX bWk";

            // Получаем фактический результат
            string actual = ds.CollectTextFromFile(testPath);

            // Проверяем
            Assert.AreEqual(expected, actual, $"Ожидалось: '{expected}', Получено: '{actual}'");



        }
    }
}
