using System.Windows.Forms.VisualStyles;
using Tyuiu.YushkovaES.Sprint6.Task2.V12.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task2.V12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void textBoxTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEnd_Click(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int end = Convert.ToInt32(textBoxEnd.Text);

                int len = ds.GetMassFunction(start, end).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, end);

                this.dataGridViewRes.Rows.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewRes.Rows.Add(Convert.ToString(start), Convert.ToString(valueArray[i]));
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 2 âûïîëíèë ñòóäåíò ãðóïïû ÏÈÍá-25-1 Êàæàõìåòîâ Àìèð Åðáîëîâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void buttonResult_MouseMove(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.Red;
        }


        private void buttonResult_MouseLeave(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.Green;
        }

        private void buttonResult_MouseClick(object sender, MouseEventArgs e)
        {
            buttonResult.BackColor = Color.YellowGreen;
        }

        private void buttonResult_MouseEnter(object sender, EventArgs e)
        {
            buttonResult.BackColor = Color.Red;
        }
    }
}
