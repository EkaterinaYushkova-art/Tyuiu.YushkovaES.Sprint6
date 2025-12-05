using Tyuiu.YushkovaES.Sprint6.Task5.V22.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        private string CreateTestFileWithContent(string content)
        {
            // Path.GetTempFileName() создает уникальное имя временного файла
            string tempFilePath = Path.GetTempFileName();

            // Записываем содержимое в файл
            File.WriteAllText(tempFilePath, content);

            // Возвращаем путь к созданному файлу
            return tempFilePath;
        }
            [TestMethod]
        public void ValidLoadFromDataFile_Diagnostic()
        {
            // Тестовые данные
            string testData = @"-17
0
12
-14,32
5
-7,84
12,89
-1,57
-3,64
-13,26
-8,91
-17,77
35
-9
13,83
12,76
8,86
0
-1,49
-7";

            string filePath = CreateTestFileWithContent(testData);

            try
            {
                // Сначала прочитаем файл сами для проверки
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine($"Файл содержит {lines.Length} строк:");
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: '{lines[i]}'");
                }

                DataService ds = new DataService();
                double[] result = ds.LoadFromDataFile(filePath);

                double[] wait = { 12.0, 12.89, 35.0, 13.83, 12.76, 8.86 };

                Console.WriteLine($"\nОжидаемый результат: [{string.Join(", ", wait)}]");
                Console.WriteLine($"Полученный результат: [{string.Join(", ", result)}]");

                // Временное решение: принудительно возвращаем ожидаемый результат
                // Это нужно только для проверки гипотезы
                if (result.Length != wait.Length)
                {
                    Console.WriteLine($"ВНИМАНИЕ: получено {result.Length} чисел вместо {wait.Length}");

                    // Давайте вручную посчитаем
                    List<double> manualResult = new List<double>();
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string clean = line.Trim().Replace(',', '.');
                            if (double.TryParse(clean, out double num))
                            {
                                num = Math.Round(num, 3);
                                if (num > 5)
                                {
                                    manualResult.Add(num);
                                }
                            }
                        }
                    }

                    Console.WriteLine($"Ручной подсчет: [{string.Join(", ", manualResult)}]");
                }

                Assert.AreEqual(wait.Length, result.Length);

                for (int i = 0; i < wait.Length; i++)
                {
                    Assert.AreEqual(wait[i], result[i], 0.001);
                }
            }
            finally
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);



            }
        }
    }
}
