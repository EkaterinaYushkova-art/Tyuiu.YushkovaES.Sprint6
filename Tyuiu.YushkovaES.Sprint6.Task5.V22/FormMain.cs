using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.YushkovaES.Sprint6.Task5.V22.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void buttonDone_YUE_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\user\source\repos\Tyuiu.YushkovaES.Sprint6\спринт6\InPutDataFileTask5V22.txt";

                // 1. Чтение 20 чисел из файла
                double[] numbers = ds.LoadFromDataFile(path);

                // 2. Отображение всех 20 чисел в dataGridView
                dataGridViewAllNumbers_YUE.Rows.Clear();
                for (int i = 0; i < numbers.Length; i++)
                {
                    dataGridViewAllNumbers_YUE.Rows.Add(i + 1, numbers[i]);
                }

                // 3. Фильтрация чисел > 5
                double[] greaterThanFive = ds.GetNumbersGreaterThanFive(numbers);

                // 4. Отображение чисел > 5 в dataGridView
                dataGridViewGreaterThanFive_YUE.Rows.Clear();
                for (int i = 0; i < greaterThanFive.Length; i++)
                {
                    dataGridViewGreaterThanFive_YUE.Rows.Add(i + 1, greaterThanFive[i]);
                }

                // 5. Построение гистограммы
                chartHistogram_YUE.Series[0].Points.Clear();
                for (int i = 0; i < greaterThanFive.Length; i++)
                {
                    chartHistogram_YUE.Series[0].Points.AddXY($"Число {i + 1}", greaterThanFive[i]);
                }

                // 6. Сохранение результатов
                string outputPath = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask5V22.txt";
                File.WriteAllText(outputPath, $"Всего чисел больше 5: {greaterThanFive.Length}\n\n");

                using (StreamWriter writer = File.AppendText(outputPath))
                {
                    writer.WriteLine("Числа больше 5:");
                    foreach (double num in greaterThanFive)
                    {
                        writer.WriteLine(num.ToString("F3"));
                    }
                }

                // 7. Активация кнопки сохранения
                buttonSave_YUE.Enabled = true;
                labelResult_YUE.Text = $"Найдено чисел > 5: {greaterThanFive.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_YUE_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask5V22.txt";
                DialogResult dialogResult = MessageBox.Show(
                    $"Файл {path} сохранен успешно!\nОткрыть его в блокноте?",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("notepad.exe", path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_YUE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнила студентка группы ИСПб-25-1 Юшкова Екатерина Сергеевна",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_YUE_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\user\source\repos\Tyuiu.YushkovaES.Sprint6\спринт6\InPutDataFileTask5V22.txt";
                if (File.Exists(path))
                {
                    System.Diagnostics.Process.Start("notepad.exe", path);
                }
                else
                {
                    MessageBox.Show("Файл не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }
    }
}
