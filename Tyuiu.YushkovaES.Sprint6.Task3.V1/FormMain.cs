using Tyuiu.YushkovaES.Sprint6.Task3.V1.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task3.V1
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
                // Создаем исходную матрицу 5x5
                int[,] matrix = {
                    {25, 20, 28, 2, 6},
                    {19, 9, 18, -7, 24},
                    {21, 16, 5, -7, -8},
                    {30, -13, 1, -15, 2},
                    {31, 9, -3, -9, -18}
                };

                // Выводим исходную матрицу в первый DataGridView
                DisplayMatrix(dataGridViewInput_SIS, matrix);

                // Сортируем матрицу
                DataService ds = new DataService();
                int[,] sortedMatrix = ds.Calculate(matrix);

                // Выводим отсортированную матрицу во второй DataGridView
                DisplayMatrix(dataGridViewOutput_SIS, sortedMatrix);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMatrix(DataGridView dgv, int[,] matrix)
        {
            // Очищаем DataGridView
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            // Добавляем столбцы
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                dgv.Columns.Add($"col{j}", $"Столбец {j + 1}");
            }

            // Добавляем строки с данными
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] row = new string[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j].ToString();
                }
                dgv.Rows.Add(row);
            }

            // Настраиваем отображение
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void buttonInfo_SIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ??? Спирин И.С.",
                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

    }
}
