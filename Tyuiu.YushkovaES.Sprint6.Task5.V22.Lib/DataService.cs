using System.Globalization;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YushkovaES.Sprint6.Task5.V22.Lib
{
    public class DataService : ISprint6Task5V22
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл '{path}' не найден");
            }

            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(path);

            List<double> result = new List<double>();

            Console.WriteLine("=== ДЕБАГ ИНФОРМАЦИЯ ===");
            Console.WriteLine($"Прочитано строк: {lines.Length}");

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                // Пропускаем пустые строки
                if (string.IsNullOrWhiteSpace(line))
                {
                    Console.WriteLine($"Строка {i + 1}: ПУСТАЯ - пропускаем");
                    continue;
                }

                string cleanedLine = line.Trim();
                Console.Write($"Строка {i + 1}: '{line}' -> '{cleanedLine}' -> ");

                // Заменяем запятую на точку для корректного парсинга
                cleanedLine = cleanedLine.Replace(',', '.');

                // Пробуем парсить с разными культурами
                bool parseSuccess = false;
                double number = 0;

                // Попробуем с InvariantCulture
                parseSuccess = double.TryParse(cleanedLine,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out number);

                if (!parseSuccess)
                {
                    // Попробуем с текущей культурой
                    parseSuccess = double.TryParse(cleanedLine, out number);
                }

                if (parseSuccess)
                {
                    // Округляем до трех знаков после запятой
                    number = Math.Round(number, 3);

                    Console.WriteLine($"число: {number}");

                    // Отбираем только числа БОЛЬШЕ 5
                    if (number > 5)
                    {
                        result.Add(number);
                        Console.WriteLine($"  -> ДОБАВЛЕНО (>{5})");
                    }
                    else
                    {
                        Console.WriteLine($"  -> НЕ добавлено (≤{5})");
                    }
                }
                else
                {
                    Console.WriteLine($"ОШИБКА ПАРСИНГА");
                }
            }

            Console.WriteLine($"=== ВСЕГО НАЙДЕНО ЧИСЕЛ > 5: {result.Count} ===");
            Console.WriteLine($"Результат: [{string.Join(", ", result)}]");

            return result.ToArray();
        }



    }
}

