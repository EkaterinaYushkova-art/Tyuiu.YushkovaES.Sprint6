using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.YushkovaES.Sprint6.Task3.V1
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

        #region #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle_SIS = new System.Windows.Forms.Label();
            this.labelInput_SIS = new System.Windows.Forms.Label();
            this.dataGridViewInput_SIS = new System.Windows.Forms.DataGridView();
            this.labelOutput_SIS = new System.Windows.Forms.Label();
            this.dataGridViewOutput_SIS = new System.Windows.Forms.DataGridView();
            this.buttonDone_SIS = new System.Windows.Forms.Button();
            this.buttonInfo_SIS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_SIS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SIS)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle_SIS
            // 
            this.labelTitle_SIS.AutoSize = true;
            this.labelTitle_SIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelTitle_SIS.Location = new System.Drawing.Point(20, 20);
            this.labelTitle_SIS.Name = "labelTitle_SIS";
            this.labelTitle_SIS.Size = new System.Drawing.Size(350, 17);
            this.labelTitle_SIS.TabIndex = 0;
            this.labelTitle_SIS.Text = "Сортировка матрицы по первому столбцу";
            // 
            // labelInput_SIS
            // 
            this.labelInput_SIS.AutoSize = true;
            this.labelInput_SIS.Location = new System.Drawing.Point(20, 60);
            this.labelInput_SIS.Name = "labelInput_SIS";
            this.labelInput_SIS.Size = new System.Drawing.Size(95, 13);
            this.labelInput_SIS.TabIndex = 1;
            this.labelInput_SIS.Text = "Исходная матрица:";
            // 
            // dataGridViewInput_SIS
            // 
            this.dataGridViewInput_SIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_SIS.Location = new System.Drawing.Point(20, 80);
            this.dataGridViewInput_SIS.Name = "dataGridViewInput_SIS";
            this.dataGridViewInput_SIS.ReadOnly = true;
            this.dataGridViewInput_SIS.Size = new System.Drawing.Size(300, 130);
            this.dataGridViewInput_SIS.TabIndex = 2;
            // 
            // labelOutput_SIS
            // 
            this.labelOutput_SIS.AutoSize = true;
            this.labelOutput_SIS.Location = new System.Drawing.Point(20, 230);
            this.labelOutput_SIS.Name = "labelOutput_SIS";
            this.labelOutput_SIS.Size = new System.Drawing.Size(132, 13);
            this.labelOutput_SIS.TabIndex = 3;
            this.labelOutput_SIS.Text = "Отсортированная матрица:";
            // 
            // dataGridViewOutput_SIS
            // 
            this.dataGridViewOutput_SIS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_SIS.Location = new System.Drawing.Point(20, 250);
            this.dataGridViewOutput_SIS.Name = "dataGridViewOutput_SIS";
            this.dataGridViewOutput_SIS.ReadOnly = true;
            this.dataGridViewOutput_SIS.Size = new System.Drawing.Size(300, 130);
            this.dataGridViewOutput_SIS.TabIndex = 4;
            // 
            // buttonDone_SIS
            // 
            this.buttonDone_SIS.Location = new System.Drawing.Point(340, 120);
            this.buttonDone_SIS.Name = "buttonDone_SIS";
            this.buttonDone_SIS.Size = new System.Drawing.Size(90, 30);
            this.buttonDone_SIS.TabIndex = 5;
            this.buttonDone_SIS.Text = "Выполнить";
            this.buttonDone_SIS.UseVisualStyleBackColor = true;
            // 
            // buttonInfo_SIS
            // 
            this.buttonInfo_SIS.Location = new System.Drawing.Point(340, 170);
            this.buttonInfo_SIS.Name = "buttonInfo_SIS";
            this.buttonInfo_SIS.Size = new System.Drawing.Size(90, 30);
            this.buttonInfo_SIS.TabIndex = 6;
            this.buttonInfo_SIS.Text = "Справка";
            this.buttonInfo_SIS.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.buttonInfo_SIS);
            this.Controls.Add(this.buttonDone_SIS);
            this.Controls.Add(this.dataGridViewOutput_SIS);
            this.Controls.Add(this.labelOutput_SIS);
            this.Controls.Add(this.dataGridViewInput_SIS);
            this.Controls.Add(this.labelInput_SIS);
            this.Controls.Add(this.labelTitle_SIS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6. Таск 2. Вариант 1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_SIS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SIS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle_SIS;
        private System.Windows.Forms.Label labelInput_SIS;
        private System.Windows.Forms.DataGridView dataGridViewInput_SIS;
        private System.Windows.Forms.Label labelOutput_SIS;
        private System.Windows.Forms.DataGridView dataGridViewOutput_SIS;
        private System.Windows.Forms.Button buttonDone_SIS;
        private System.Windows.Forms.Button buttonInfo_SIS;
    }
}
