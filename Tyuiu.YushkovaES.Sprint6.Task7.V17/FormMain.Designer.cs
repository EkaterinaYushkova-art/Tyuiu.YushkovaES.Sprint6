using WinFormsButton = System.Windows.Forms.Button;
using WinFormsGroupBox = System.Windows.Forms.GroupBox;
using WinFormsTextBox = System.Windows.Forms.TextBox;
using WinFormsDataGridView = System.Windows.Forms.DataGridView;
using System.Windows.Forms;


namespace Tyuiu.YushkovaES.Sprint6.Task7.V17
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonDone_KG;
        private System.Windows.Forms.GroupBox groupBoxIn_KG;
        private System.Windows.Forms.GroupBox groupBoxOut_KG;
        private System.Windows.Forms.TextBox textBoxPathIn_KG;
        private System.Windows.Forms.TextBox textBoxResult_KG;
        private System.Windows.Forms.DataGridView dataGridViewIn_KG;
        private System.Windows.Forms.DataGridView dataGridViewOut_KG;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonInfo = new Button();
            buttonSave = new Button();
            buttonRes = new Button();
            buttonLoad = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            dataGridViewIn = new DataGridView();
            splitter1 = new Splitter();
            panel4 = new Panel();
            groupBox3 = new GroupBox();
            dataGridViewOut = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogData = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panel4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonInfo);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonRes);
            panel1.Controls.Add(buttonLoad);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 100);
            panel1.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.BackColor = Color.Yellow;
            buttonInfo.Location = new Point(945, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(127, 74);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Blue;
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(278, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(127, 74);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonRes
            // 
            buttonRes.BackColor = Color.Lime;
            buttonRes.Enabled = false;
            buttonRes.Location = new Point(145, 12);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(127, 74);
            buttonRes.TabIndex = 1;
            buttonRes.Text = "Выполнить";
            buttonRes.UseVisualStyleBackColor = false;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = Color.Cyan;
            buttonLoad.Location = new Point(12, 12);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(127, 74);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Загрузить";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 68);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1084, 68);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1078, 46);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 168);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 393);
            panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewIn);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 393);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод:";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.AllowUserToAddRows = false;
            dataGridViewIn.AllowUserToDeleteRows = false;
            dataGridViewIn.AllowUserToResizeColumns = false;
            dataGridViewIn.AllowUserToResizeRows = false;
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.ColumnHeadersVisible = false;
            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.Location = new Point(3, 19);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersVisible = false;
            dataGridViewIn.Size = new Size(194, 371);
            dataGridViewIn.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(200, 168);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(10, 393);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(210, 168);
            panel4.Name = "panel4";
            panel4.Size = new Size(874, 393);
            panel4.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewOut);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(874, 393);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.AllowUserToAddRows = false;
            dataGridViewOut.AllowUserToDeleteRows = false;
            dataGridViewOut.AllowUserToResizeColumns = false;
            dataGridViewOut.AllowUserToResizeRows = false;
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.ColumnHeadersVisible = false;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(3, 19);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersVisible = false;
            dataGridViewOut.Size = new Size(868, 371);
            dataGridViewOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            openFileDialogTask.FileOk += openFileDialog1_FileOk;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel4);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1100, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonInfo;
        private Button buttonSave;
        private Button buttonRes;
        private Button buttonLoad;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Panel panel3;
        private GroupBox groupBox2;
        private Splitter splitter1;
        private Panel panel4;
        private GroupBox groupBox3;
        private OpenFileDialog openFileDialogTask;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private SaveFileDialog saveFileDialogData;
      
    }
}
