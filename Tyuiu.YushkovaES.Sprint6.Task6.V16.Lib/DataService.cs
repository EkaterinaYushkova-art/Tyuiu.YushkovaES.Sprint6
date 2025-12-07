using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.YushkovaES.Sprint6.Task6.V16.Lib
{
    public class DataService : ISprint6Task6V16
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разбиваем строку на слова по пробелам
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        // Проверяем, содержит ли слово букву 'b' или 'B'
                        if (word.Contains('b') || word.Contains('B'))
                        {
                            result.Append(word).Append(" ");
                        }
                    }
                }
            }

            // Убираем последний пробел, если он есть
            if (result.Length > 0)
            {
                result.Length--; // Удаляем последний символ (пробел)
            }

            return result.ToString();



        }
    }
}
