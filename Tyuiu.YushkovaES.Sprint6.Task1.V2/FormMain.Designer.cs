using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.YushkovaES.Sprint6.Task0.V2
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
            labelStart_SIS = new Label();
            textBoxStart_SIS = new TextBox();
            labelStop_SIS = new Label();
            textBoxStop_SIS = new TextBox();
            buttonDone_SIS = new Button();
            buttonInfo_SIS = new Button();
            textBoxResult_SIS = new TextBox();
            labelTitle_SIS = new Label();
            SuspendLayout();
            // 
            // labelStart_SIS
            // 
            labelStart_SIS.AutoSize = true;
            labelStart_SIS.Location = new Point(27, 92);
            labelStart_SIS.Margin = new Padding(4, 0, 4, 0);
            labelStart_SIS.Name = "labelStart_SIS";
            labelStart_SIS.Size = new Size(143, 20);
            labelStart_SIS.TabIndex = 1;
            labelStart_SIS.Text = "Начало диапазона:";
            // 
            // textBoxStart_SIS
            // 
            textBoxStart_SIS.Location = new Point(173, 88);
            textBoxStart_SIS.Margin = new Padding(4, 5, 4, 5);
            textBoxStart_SIS.Name = "textBoxStart_SIS";
            textBoxStart_SIS.Size = new Size(132, 27);
            textBoxStart_SIS.TabIndex = 2;
            textBoxStart_SIS.Text = "-5";
            // 
            // labelStop_SIS
            // 
            labelStop_SIS.AutoSize = true;
            labelStop_SIS.Location = new Point(27, 138);
            labelStop_SIS.Margin = new Padding(4, 0, 4, 0);
            labelStop_SIS.Name = "labelStop_SIS";
            labelStop_SIS.Size = new Size(135, 20);
            labelStop_SIS.TabIndex = 3;
            labelStop_SIS.Text = "Конец диапазона:";
            // 
            // textBoxStop_SIS
            // 
            textBoxStop_SIS.Location = new Point(173, 134);
            textBoxStop_SIS.Margin = new Padding(4, 5, 4, 5);
            textBoxStop_SIS.Name = "textBoxStop_SIS";
            textBoxStop_SIS.Size = new Size(132, 27);
            textBoxStop_SIS.TabIndex = 4;
            textBoxStop_SIS.Text = "5";
            // 
            // buttonDone_SIS
            // 
            buttonDone_SIS.Location = new Point(333, 85);
            buttonDone_SIS.Margin = new Padding(4, 5, 4, 5);
            buttonDone_SIS.Name = "buttonDone_SIS";
            buttonDone_SIS.Size = new Size(120, 35);
            buttonDone_SIS.TabIndex = 5;
            buttonDone_SIS.Text = "Выполнить";
            buttonDone_SIS.UseVisualStyleBackColor = true;
            buttonDone_SIS.Click += buttonDone_SIS_Click;
            // 
            // buttonInfo_SIS
            // 
            buttonInfo_SIS.Location = new Point(333, 131);
            buttonInfo_SIS.Margin = new Padding(4, 5, 4, 5);
            buttonInfo_SIS.Name = "buttonInfo_SIS";
            buttonInfo_SIS.Size = new Size(120, 35);
            buttonInfo_SIS.TabIndex = 6;
            buttonInfo_SIS.Text = "Справка";
            buttonInfo_SIS.UseVisualStyleBackColor = true;
            buttonInfo_SIS.Click += buttonInfo_SIS_Click;
            // 
            // textBoxResult_SIS
            // 
            textBoxResult_SIS.Location = new Point(27, 185);
            textBoxResult_SIS.Margin = new Padding(4, 5, 4, 5);
            textBoxResult_SIS.Multiline = true;
            textBoxResult_SIS.Name = "textBoxResult_SIS";
            textBoxResult_SIS.ReadOnly = true;
            textBoxResult_SIS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SIS.Size = new Size(425, 275);
            textBoxResult_SIS.TabIndex = 7;
            // 
            // labelTitle_SIS
            // 
            labelTitle_SIS.AutoSize = true;
            labelTitle_SIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            labelTitle_SIS.Location = new Point(27, 31);
            labelTitle_SIS.Margin = new Padding(4, 0, 4, 0);
            labelTitle_SIS.Name = "labelTitle_SIS";
            labelTitle_SIS.Size = new Size(236, 20);
            labelTitle_SIS.TabIndex = 0;
            labelTitle_SIS.Text = "Табулирование функции";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 492);
            Controls.Add(textBoxResult_SIS);
            Controls.Add(buttonInfo_SIS);
            Controls.Add(buttonDone_SIS);
            Controls.Add(textBoxStop_SIS);
            Controls.Add(labelStop_SIS);
            Controls.Add(textBoxStart_SIS);
            Controls.Add(labelStart_SIS);
            Controls.Add(labelTitle_SIS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6. Таск 1. Вариант 2";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle_SIS;
        private System.Windows.Forms.Label labelStart_SIS;
        private System.Windows.Forms.TextBox textBoxStart_SIS;
        private System.Windows.Forms.Label labelStop_SIS;
        private System.Windows.Forms.TextBox textBoxStop_SIS;
        private System.Windows.Forms.Button buttonDone_SIS;
        private System.Windows.Forms.Button buttonInfo_SIS;
        private System.Windows.Forms.TextBox textBoxResult_SIS;
    }
}