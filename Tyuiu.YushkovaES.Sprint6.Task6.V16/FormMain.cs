using Tyuiu.YushkovaES.Sprint6.Task6.V16.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task6.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string OpenFilePath;
        DataService ds = new DataService();
        private void buttonRes_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = ds.CollectTextFromFile(OpenFilePath);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            OpenFilePath = openFileDialogTask.FileName;
            textBoxIn.Text = File.ReadAllText(OpenFilePath);
            buttonRes.Enabled = true;

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
