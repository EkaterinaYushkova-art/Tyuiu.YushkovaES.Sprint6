using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Tyuiu.YushkovaES.Sprint6.Task2.V12
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            labelEnd = new Label();
            labelStart = new Label();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            groupBoxInput = new GroupBox();
            buttonInfo = new Button();
            buttonResult = new Button();
            dataGridViewRes = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            RES = new DataGridViewTextBoxColumn();
            groupBoxTask.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(35, 24);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(598, 259);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(12, 18);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(577, 235);
            textBoxTask.TabIndex = 1;
            textBoxTask.Text = "Протабулировать функцию sin(x) на заданном диапозоне.\r\nРезультат вывести в DataGridView и построить график функции.\r\n";
            textBoxTask.TextChanged += textBoxTask_TextChanged;
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(222, 43);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(94, 15);
            labelEnd.TabIndex = 9;
            labelEnd.Text = "Конечная точка";
            labelEnd.Click += labelEnd_Click;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(47, 43);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(101, 15);
            labelStart.TabIndex = 8;
            labelStart.Text = "Начальная точка";
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(197, 61);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(160, 23);
            textBoxEnd.TabIndex = 7;
            textBoxEnd.TextChanged += textBoxEnd_TextChanged;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(21, 61);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(160, 23);
            textBoxStart.TabIndex = 6;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxStart);
            groupBoxInput.Controls.Add(labelEnd);
            groupBoxInput.Controls.Add(textBoxEnd);
            groupBoxInput.Controls.Add(labelStart);
            groupBoxInput.Location = new Point(38, 307);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(386, 131);
            groupBoxInput.TabIndex = 10;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.DodgerBlue;
            buttonInfo.Location = new Point(445, 380);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(175, 58);
            buttonInfo.TabIndex = 11;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.MediumSpringGreen;
            buttonResult.Location = new Point(445, 307);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(175, 58);
            buttonResult.TabIndex = 12;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            buttonResult.MouseClick += buttonResult_MouseClick;
            buttonResult.MouseEnter += buttonResult_MouseEnter;
            buttonResult.MouseLeave += buttonResult_MouseLeave;
            // 
            // dataGridViewRes
            // 
            dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes.Columns.AddRange(new DataGridViewColumn[] { X, RES });
            dataGridViewRes.Location = new Point(651, 33);
            dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewRes.RowHeadersVisible = false;
            dataGridViewRes.Size = new Size(126, 405);
            dataGridViewRes.TabIndex = 13;
            dataGridViewRes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // RES
            // 
            RES.HeaderText = "F(X)";
            RES.Name = "RES";
            RES.ReadOnly = true;
            RES.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 450);
            Controls.Add(dataGridViewRes);
            Controls.Add(buttonResult);
            Controls.Add(buttonInfo);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private Label labelEnd;
        private Label labelStart;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private TextBox textBoxTask;
        private GroupBox groupBoxInput;
        private Button buttonInfo;
        private Button buttonResult;
        private DataGridView dataGridViewRes;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn RES;
    }
}
