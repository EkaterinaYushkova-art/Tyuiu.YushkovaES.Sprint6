using Tyuiu.YushkovaES.Sprint6.Task4.V19.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task4.V19
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

                // Вычисляем значения функции
                DataService ds = new DataService();
                double[] values = ds.GetMassFunction(startValue, stopValue);

                // Выводим в TextBox
                DisplayInTextBox(values, startValue);

                // Сохраняем в файл
                string filePath = ds.SaveToFileData(startValue, stopValue, values);
                labelStatus_SIS.Text = $"Файл сохранен: {filePath}";
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayInTextBox(double[] values, int startValue)
        {
            string result = "Таблица значений функции:\r\n";
            result += "F(x) = (5x + 2.5) / (sin(x) - 2) + 2\r\n";
            result += $"Диапазон: [{textBoxStart_SIS.Text}; {textBoxStop_SIS.Text}]\r\n";
            result += "Шаг: 1\r\n\r\n";

            for (int i = 0; i < values.Length; i++)
            {
                int x = startValue + i;
                result += $"f({x}) = {values[i]}\r\n";
            }

            textBoxResult_SIS.Text = result;
        }

        private void buttonInfo_SIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ??? Спирин И.С.",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
