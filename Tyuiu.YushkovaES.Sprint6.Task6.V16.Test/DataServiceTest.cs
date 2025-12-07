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
            string testPath = @"C:\Users\user\source\repos\Tyuiu.YushkovaES.Sprint6\спринт6\InPutDataFileTask6V16.txt";

            // Записываем тестовые данные в файл
            string testData = @"UPPfdzU ulzPXa UpGwjzkBH xvfsWpk
BYiySs S OHcr NsMnNzS Y KgepHrKCHa
BXGdYDF brIBPtX vatYxkk gLertvwzs
KyiidnDo FVUh XNQBU sMLuPzlvneiTo
XIpph QN hZznJL bWk Rz tfouGdncXlJ";

            // Явно указываем кодировку UTF8 при записи
            File.WriteAllText(testPath, testData);

            // Ожидаем ТОЛЬКО слова со строчной 'b'
            string expected = "brIBPtX bWk";

            string actual = ds.CollectTextFromFile(testPath);

            Assert.AreEqual(expected, actual,
                $"Ожидалось: '{expected}'\nПолучено: '{actual}'");




        }
    }
}
