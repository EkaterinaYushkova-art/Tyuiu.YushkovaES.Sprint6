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
            this.labelStart_SIS = new System.Windows.Forms.Label();
            this.textBoxStart_SIS = new System.Windows.Forms.TextBox();
            this.labelStop_SIS = new System.Windows.Forms.Label();
            this.textBoxStop_SIS = new System.Windows.Forms.TextBox();
            this.buttonDone_SIS = new System.Windows.Forms.Button();
            this.buttonInfo_SIS = new System.Windows.Forms.Button();
            this.textBoxResult_SIS = new System.Windows.Forms.TextBox();
            this.labelTitle_SIS = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // labelTitle_SIS
            // 
            this.labelTitle_SIS.AutoSize = true;
            this.labelTitle_SIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelTitle_SIS.Location = new System.Drawing.Point(20, 20);
            this.labelTitle_SIS.Name = "labelTitle_SIS";
            this.labelTitle_SIS.Size = new System.Drawing.Size(180, 17);
            this.labelTitle_SIS.TabIndex = 0;
            this.labelTitle_SIS.Text = "Табулирование функции";

            // labelStart_SIS
            // 
            this.labelStart_SIS.AutoSize = true;
            this.labelStart_SIS.Location = new System.Drawing.Point(20, 60);
            this.labelStart_SIS.Name = "labelStart_SIS";
            this.labelStart_SIS.Size = new System.Drawing.Size(96, 13);
            this.labelStart_SIS.TabIndex = 1;
            this.labelStart_SIS.Text = "Начало диапазона:";

            // textBoxStart_SIS
            // 
            this.textBoxStart_SIS.Location = new System.Drawing.Point(130, 57);
            this.textBoxStart_SIS.Name = "textBoxStart_SIS";
            this.textBoxStart_SIS.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SIS.TabIndex = 2;
            this.textBoxStart_SIS.Text = "-5";

            // labelStop_SIS
            // 
            this.labelStop_SIS.AutoSize = true;
            this.labelStop_SIS.Location = new System.Drawing.Point(20, 90);
            this.labelStop_SIS.Name = "labelStop_SIS";
            this.labelStop_SIS.Size = new System.Drawing.Size(93, 13);
            this.labelStop_SIS.TabIndex = 3;
            this.labelStop_SIS.Text = "Конец диапазона:";

            // textBoxStop_SIS
            // 
            this.textBoxStop_SIS.Location = new System.Drawing.Point(130, 87);
            this.textBoxStop_SIS.Name = "textBoxStop_SIS";
            this.textBoxStop_SIS.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_SIS.TabIndex = 4;
            this.textBoxStop_SIS.Text = "5";

            // buttonDone_SIS
            // 
            this.buttonDone_SIS.Location = new System.Drawing.Point(250, 55);
            this.buttonDone_SIS.Name = "buttonDone_SIS";
            this.buttonDone_SIS.Size = new System.Drawing.Size(90, 23);
            this.buttonDone_SIS.TabIndex = 5;
            this.buttonDone_SIS.Text = "Выполнить";
            this.buttonDone_SIS.UseVisualStyleBackColor = true;
            this.buttonDone_SIS.Click += new System.EventHandler(this.buttonDone_SIS_Click);

            // buttonInfo_SIS
            // 
            this.buttonInfo_SIS.Location = new System.Drawing.Point(250, 85);
            this.buttonInfo_SIS.Name = "buttonInfo_SIS";
            this.buttonInfo_SIS.Size = new System.Drawing.Size(90, 23);
            this.buttonInfo_SIS.TabIndex = 6;
            this.buttonInfo_SIS.Text = "Справка";
            this.buttonInfo_SIS.UseVisualStyleBackColor = true;
            this.buttonInfo_SIS.Click += new System.EventHandler(this.buttonInfo_SIS_Click);

            // textBoxResult_SIS
            // 
            this.textBoxResult_SIS.Location = new System.Drawing.Point(20, 120);
            this.textBoxResult_SIS.Multiline = true;
            this.textBoxResult_SIS.Name = "textBoxResult_SIS";
            this.textBoxResult_SIS.ReadOnly = true;
            this.textBoxResult_SIS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SIS.Size = new System.Drawing.Size(320, 180);
            this.textBoxResult_SIS.TabIndex = 7;

            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 320);
            this.Controls.Add(this.textBoxResult_SIS);
            this.Controls.Add(this.buttonInfo_SIS);
            this.Controls.Add(this.buttonDone_SIS);
            this.Controls.Add(this.textBoxStop_SIS);
            this.Controls.Add(this.labelStop_SIS);
            this.Controls.Add(this.textBoxStart_SIS);
            this.Controls.Add(this.labelStart_SIS);
            this.Controls.Add(this.labelTitle_SIS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6. Таск 1. Вариант 2";
            this.ResumeLayout(false);
            this.PerformLayout();
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