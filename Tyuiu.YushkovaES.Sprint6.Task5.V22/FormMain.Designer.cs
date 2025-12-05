namespace Tyuiu.YushkovaES.Sprint6.Task5.V22
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelTop_YUE = new System.Windows.Forms.Panel();
            this.labelTask_YUE = new System.Windows.Forms.Label();
            this.panelBottom_YUE = new System.Windows.Forms.Panel();
            this.buttonHelp_YUE = new System.Windows.Forms.Button();
            this.buttonSave_YUE = new System.Windows.Forms.Button();
            this.buttonDone_YUE = new System.Windows.Forms.Button();
            this.buttonOpenFile_YUE = new System.Windows.Forms.Button();
            this.groupBoxAllNumbers_YUE = new System.Windows.Forms.GroupBox();
            this.dataGridViewAllNumbers_YUE = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxGreaterThanFive_YUE = new System.Windows.Forms.GroupBox();
            this.dataGridViewGreaterThanFive_YUE = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxHistogram_YUE = new System.Windows.Forms.GroupBox();
            this.chartHistogram_YUE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_YUE = new System.Windows.Forms.Label();
            this.labelPath_YUE = new System.Windows.Forms.Label();
            this.textBoxPath_YUE = new System.Windows.Forms.TextBox();
            this.panelTop_YUE.SuspendLayout();
            this.panelBottom_YUE.SuspendLayout();
            this.groupBoxAllNumbers_YUE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllNumbers_YUE)).BeginInit();
            this.groupBoxGreaterThanFive_YUE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGreaterThanFive_YUE)).BeginInit();
            this.groupBoxHistogram_YUE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram_YUE)).BeginInit();
            this.SuspendLayout();

            // panelTop_YUE
            this.panelTop_YUE.BackColor = System.Drawing.Color.SkyBlue;
            this.panelTop_YUE.Controls.Add(this.labelTask_YUE);
            this.panelTop_YUE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_YUE.Location = new System.Drawing.Point(0, 0);
            this.panelTop_YUE.Name = "panelTop_YUE";
            this.panelTop_YUE.Size = new System.Drawing.Size(1000, 80);
            this.panelTop_YUE.TabIndex = 0;

            // labelTask_YUE
            this.labelTask_YUE.AutoSize = true;
            this.labelTask_YUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelTask_YUE.Location = new System.Drawing.Point(20, 20);
            this.labelTask_YUE.Name = "labelTask_YUE";
            this.labelTask_YUE.Size = new System.Drawing.Size(900, 40);
            this.labelTask_YUE.Text = "Спринт 6 | Таск 5 | Вариант 22 | Юшкова Е.С.\nПрочитать данные из файла. Вывести в dataGridView список из 20 чисел. Вывести все числа больше 5. Построить гистограмму.";
            this.labelTask_YUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // panelBottom_YUE
            this.panelBottom_YUE.BackColor = System.Drawing.Color.LightGray;
            this.panelBottom_YUE.Controls.Add(this.buttonHelp_YUE);
            this.panelBottom_YUE.Controls.Add(this.buttonSave_YUE);
            this.panelBottom_YUE.Controls.Add(this.buttonDone_YUE);
            this.panelBottom_YUE.Controls.Add(this.buttonOpenFile_YUE);
            this.panelBottom_YUE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom_YUE.Location = new System.Drawing.Point(0, 550);
            this.panelBottom_YUE.Name = "panelBottom_YUE";
            this.panelBottom_YUE.Size = new System.Drawing.Size(1000, 50);
            this.panelBottom_YUE.TabIndex = 1;

            // buttonHelp_YUE
            this.buttonHelp_YUE.Location = new System.Drawing.Point(800, 10);
            this.buttonHelp_YUE.Name = "buttonHelp_YUE";
            this.buttonHelp_YUE.Size = new System.Drawing.Size(80, 30);
            this.buttonHelp_YUE.Text = "Справка";
            this.buttonHelp_YUE.Click += new System.EventHandler(this.buttonHelp_YUE_Click);

            // buttonSave_YUE
            this.buttonSave_YUE.Enabled = false;
            this.buttonSave_YUE.Location = new System.Drawing.Point(700, 10);
            this.buttonSave_YUE.Name = "buttonSave_YUE";
            this.buttonSave_YUE.Size = new System.Drawing.Size(80, 30);
            this.buttonSave_YUE.Text = "Сохранить";
            this.buttonSave_YUE.Click += new System.EventHandler(this.buttonSave_YUE_Click);

            // buttonDone_YUE
            this.buttonDone_YUE.Location = new System.Drawing.Point(600, 10);
            this.buttonDone_YUE.Name = "buttonDone_YUE";
            this.buttonDone_YUE.Size = new System.Drawing.Size(80, 30);
            this.buttonDone_YUE.Text = "Выполнить";
            this.buttonDone_YUE.Click += new System.EventHandler(this.buttonDone_YUE_Click);

            // buttonOpenFile_YUE
            this.buttonOpenFile_YUE.Location = new System.Drawing.Point(500, 10);
            this.buttonOpenFile_YUE.Name = "buttonOpenFile_YUE";
            this.buttonOpenFile_YUE.Size = new System.Drawing.Size(80, 30);
            this.buttonOpenFile_YUE.Text = "Открыть файл";
            this.buttonOpenFile_YUE.Click += new System.EventHandler(this.buttonOpenFile_YUE_Click);

            // labelPath_YUE
            this.labelPath_YUE.AutoSize = true;
            this.labelPath_YUE.Location = new System.Drawing.Point(20, 90);
            this.labelPath_YUE.Name = "labelPath_YUE";
            this.labelPath_YUE.Size = new System.Drawing.Size(120, 16);
            this.labelPath_YUE.Text = "Путь к файлу:";

            // textBoxPath_YUE
            this.textBoxPath_YUE.Location = new System.Drawing.Point(150, 87);
            this.textBoxPath_YUE.ReadOnly = true;
            this.textBoxPath_YUE.Size = new System.Drawing.Size(800, 22);
            this.textBoxPath_YUE.Text = @"C:\Users\user\source\repos\Tyuiu.YushkovaES.Sprint6\спринт6\InPutDataFileTask5V22.txt";

            // labelResult_YUE
            this.labelResult_YUE.AutoSize = true;
            this.labelResult_YUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelResult_YUE.ForeColor = System.Drawing.Color.Blue;
            this.labelResult_YUE.Location = new System.Drawing.Point(20, 120);
            this.labelResult_YUE.Name = "labelResult_YUE";
            this.labelResult_YUE.Size = new System.Drawing.Size(200, 20);
            this.labelResult_YUE.Text = "Нажмите 'Выполнить'";

            // groupBoxAllNumbers_YUE
            this.groupBoxAllNumbers_YUE.Controls.Add(this.dataGridViewAllNumbers_YUE);
            this.groupBoxAllNumbers_YUE.Location = new System.Drawing.Point(20, 150);
            this.groupBoxAllNumbers_YUE.Name = "groupBoxAllNumbers_YUE";
            this.groupBoxAllNumbers_YUE.Size = new System.Drawing.Size(300, 350);
            this.groupBoxAllNumbers_YUE.Text = "Все 20 чисел (округлены до 3 знаков)";

            // dataGridViewAllNumbers_YUE
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewAllNumbers_YUE.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAllNumbers_YUE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllNumbers_YUE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.ColumnIndex,
                this.ColumnValue});
            this.dataGridViewAllNumbers_YUE.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewAllNumbers_YUE.Name = "dataGridViewAllNumbers_YUE";
            this.dataGridViewAllNumbers_YUE.RowHeadersVisible = false;
            this.dataGridViewAllNumbers_YUE.RowTemplate.Height = 24;
            this.dataGridViewAllNumbers_YUE.Size = new System.Drawing.Size(280, 310);

            // ColumnIndex
            this.ColumnIndex.HeaderText = "№";
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.Width = 50;

            // ColumnValue
            this.ColumnValue.HeaderText = "Значение";
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.Width = 150;

            // groupBoxGreaterThanFive_YUE
            this.groupBoxGreaterThanFive_YUE.Controls.Add(this.dataGridViewGreaterThanFive_YUE);
            this.groupBoxGreaterThanFive_YUE.Location = new System.Drawing.Point(340, 150);
            this.groupBoxGreaterThanFive_YUE.Name = "groupBoxGreaterThanFive_YUE";
            this.groupBoxGreaterThanFive_YUE.Size = new System.Drawing.Size(300, 350);
            this.groupBoxGreaterThanFive_YUE.Text = "Числа больше 5";

            // dataGridViewGreaterThanFive_YUE
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewGreaterThanFive_YUE.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGreaterThanFive_YUE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGreaterThanFive_YUE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.dataGridViewTextBoxColumn1,
                this.dataGridViewTextBoxColumn2});
            this.dataGridViewGreaterThanFive_YUE.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewGreaterThanFive_YUE.Name = "dataGridViewGreaterThanFive_YUE";
            this.dataGridViewGreaterThanFive_YUE.RowHeadersVisible = false;
            this.dataGridViewGreaterThanFive_YUE.RowTemplate.Height = 24;
            this.dataGridViewGreaterThanFive_YUE.Size = new System.Drawing.Size(280, 310);

            // dataGridViewTextBoxColumn1
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;

            // dataGridViewTextBoxColumn2
            this.dataGridViewTextBoxColumn2.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;

            // groupBoxHistogram_YUE
            this.groupBoxHistogram_YUE.Controls.Add(this.chartHistogram_YUE);
            this.groupBoxHistogram_YUE.Location = new System.Drawing.Point(660, 150);
            this.groupBoxHistogram_YUE.Name = "groupBoxHistogram_YUE";
            this.groupBoxHistogram_YUE.Size = new System.Drawing.Size(320, 350);
            this.groupBoxHistogram_YUE.Text = "Гистограмма чисел > 5";

            // chartHistogram_YUE
            chartArea1.Name = "ChartArea1";
            this.chartHistogram_YUE.ChartAreas.Add(chartArea1);
            this.chartHistogram_YUE.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartHistogram_YUE.Legends.Add(legend1);
            this.chartHistogram_YUE.Location = new System.Drawing.Point(3, 18);
            this.chartHistogram_YUE.Name = "chartHistogram_YUE";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Числа > 5";
            this.chartHistogram_YUE.Series.Add(series1);
            this.chartHistogram_YUE.Size = new System.Drawing.Size(314, 329);

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.groupBoxHistogram_YUE);
            this.Controls.Add(this.groupBoxGreaterThanFive_YUE);
            this.Controls.Add(this.groupBoxAllNumbers_YUE);
            this.Controls.Add(this.labelResult_YUE);
            this.Controls.Add(this.textBoxPath_YUE);
            this.Controls.Add(this.labelPath_YUE);
            this.Controls.Add(this.panelBottom_YUE);
            this.Controls.Add(this.panelTop_YUE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 22 | Юшкова Е.С.";
            this.panelTop_YUE.ResumeLayout(false);
            this.panelTop_YUE.PerformLayout();
            this.panelBottom_YUE.ResumeLayout(false);
            this.groupBoxAllNumbers_YUE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllNumbers_YUE)).EndInit();
            this.groupBoxGreaterThanFive_YUE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGreaterThanFive_YUE)).EndInit();
            this.groupBoxHistogram_YUE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram_YUE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Объявление компонентов
        private System.Windows.Forms.Panel panelTop_YUE;
        private System.Windows.Forms.Label labelTask_YUE;
        private System.Windows.Forms.Panel panelBottom_YUE;
        private System.Windows.Forms.Button buttonHelp_YUE;
        private System.Windows.Forms.Button buttonSave_YUE;
        private System.Windows.Forms.Button buttonDone_YUE;
        private System.Windows.Forms.Button buttonOpenFile_YUE;
        private System.Windows.Forms.GroupBox groupBoxAllNumbers_YUE;
        private System.Windows.Forms.DataGridView dataGridViewAllNumbers_YUE;
        private System.Windows.Forms.GroupBox groupBoxGreaterThanFive_YUE;
        private System.Windows.Forms.DataGridView dataGridViewGreaterThanFive_YUE;
        private System.Windows.Forms.GroupBox groupBoxHistogram_YUE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram_YUE;
        private System.Windows.Forms.Label labelResult_YUE;
        private System.Windows.Forms.Label labelPath_YUE;
        private System.Windows.Forms.TextBox textBoxPath_YUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }

}

}