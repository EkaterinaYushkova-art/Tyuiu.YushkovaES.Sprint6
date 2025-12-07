using System.IO;
using System.Windows.Forms;
using Tyuiu.YushkovaES.Sprint6.Task7.V17.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task7.V17
{
    public partial class FormMain : Form
    {
       

        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        static string openFilePath;
        static int rows;
        static int columns;
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            return arrayValues;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn.ColumnCount = columns;
            dataGridViewIn.RowCount = rows;
            dataGridViewOut.ColumnCount = columns;
            dataGridViewOut.RowCount = rows;


            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn.Columns[i].Width = 25;
                dataGridViewOut.Columns[i].Width = 25;
            }


            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonRes.Enabled = true;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void splitter1_SplitterMoved_1(object sender, SplitterEventArgs e)
        {

        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogData.FileName = "OutPutFileTask7V22.csv";
            saveFileDialogData.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogData.ShowDialog();

            string path = saveFileDialogData.FileName;

            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }


            int rows = dataGridViewOut.RowCount;
            int columns = dataGridViewOut.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
