using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tyuiu.YushkovaES.Sprint6.Task6.V16
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonInfo = new Button();
            buttonRes = new Button();
            buttonLoad = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            textBoxIn = new TextBox();
            splitter1 = new Splitter();
            panel4 = new Panel();
            groupBox3 = new GroupBox();
            textBoxOut = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonInfo);
            panel1.Controls.Add(buttonRes);
            panel1.Controls.Add(buttonLoad);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 70);
            panel1.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.BackColor = Color.FromArgb(255, 192, 255);
            buttonInfo.Location = new Point(879, 10);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(93, 52);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "Справка";
            toolTip1.SetToolTip(buttonInfo, "О разработчике");
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.UseWaitCursor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonRes
            // 
            buttonRes.BackColor = Color.Lime;
            buttonRes.Enabled = false;
            buttonRes.Location = new Point(96, 10);
            buttonRes.Name = "buttonRes";
            buttonRes.Size = new Size(93, 52);
            buttonRes.TabIndex = 1;
            buttonRes.Text = "Выполнить";
            toolTip1.SetToolTip(buttonRes, "Выполнить Таск");
            buttonRes.UseVisualStyleBackColor = false;
            buttonRes.UseWaitCursor = true;
            buttonRes.Click += buttonRes_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = Color.Cyan;
            buttonLoad.Location = new Point(10, 10);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(80, 52);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Загрузить";
            toolTip1.SetToolTip(buttonLoad, "Открыть файл.");
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.UseWaitCursor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 82);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 82);
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
            textBox1.Size = new Size(978, 60);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(456, 259);
            panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxIn);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(456, 259);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод:";
            // 
            // textBoxIn
            // 
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.Location = new Point(3, 19);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ReadOnly = true;
            textBoxIn.Size = new Size(450, 237);
            textBoxIn.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(456, 152);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 259);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(459, 152);
            panel4.Name = "panel4";
            panel4.Size = new Size(525, 259);
            panel4.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxOut);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(525, 259);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод:";
            // 
            // textBoxOut
            // 
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.Location = new Point(3, 19);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.Size = new Size(519, 237);
            textBoxOut.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 411);
            Controls.Add(panel4);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRes;
        private Button buttonLoad;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private Panel panel4;
        private Button buttonInfo;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialogTask;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxIn;
        private TextBox textBoxOut;
    }
}

