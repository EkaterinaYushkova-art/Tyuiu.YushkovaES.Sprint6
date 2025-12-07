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

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разбиваем строку на слова
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        // Ищем ТОЛЬКО строчную букву 'b'
                        if (word.Contains('b'))
                        {
                            result.Append(word).Append(" ");
                        }
                    }
                }
            }

            // Убираем последний пробел
            return result.ToString().TrimEnd();


        }
    }
}
