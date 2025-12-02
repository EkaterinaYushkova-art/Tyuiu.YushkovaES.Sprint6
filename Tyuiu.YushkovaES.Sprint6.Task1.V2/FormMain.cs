using System;
using System.Windows.Forms;
using Tyuiu.YushkovaES.Sprint6.Task1.V2.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task0.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_SIS_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_SIS.Text);
                int stopValue = Convert.ToInt32(textBoxStop_SIS.Text);

                DataService ds = new DataService();
                double[] values = ds.GetMassFunction(startValue, stopValue);

                // Формируем строку для вывода
                string result = "Таблица значений функции:\r\n";
                result += "F(x) = (5x + 2.5) / (sin(x) + 2) + 2x + 2\r\n";
                result += $"Диапазон: [{startValue}; {stopValue}]\r\n";
                result += "Шаг: 1\r\n\r\n";

                for (int i = 0; i < values.Length; i++)
                {
                    int x = startValue + i;
                    result += $"f({x}) = {values[i]}\r\n";
                }

                textBoxResult_SIS.Text = result;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_SIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ??? Спирин И.С.",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}