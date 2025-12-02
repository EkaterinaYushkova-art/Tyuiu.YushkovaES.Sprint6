using System;
using System.Windows.Forms;
using Tyuiu.YushkovaES.Sprint6.Task0.V22.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task0.V22
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
                int x = Convert.ToInt32(textBoxVarA_SIS.Text);
                DataService ds = new DataService();
                double y = ds.Calculate(x);
                textBoxResult_SIS.Text = y.ToString("F3");
            }
            catch
            {
                MessageBox.Show("Введите корректное значение X.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_SIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Спринт 6 | Задание 0 | Вариант 22\n\n" +
                "Вычислить значение функции F(x) = 0.7x^3 + 1.52x^2 при x = 2.\n" +
                "Результат вывести в текстовое поле, округлив до трёх знаков после запятой.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}