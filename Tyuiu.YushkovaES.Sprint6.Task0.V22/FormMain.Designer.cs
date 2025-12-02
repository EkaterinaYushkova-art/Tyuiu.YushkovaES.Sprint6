namespace Tyuiu.YushkovaES.Sprint6.Task0.V22
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
            pictureBoxFormula_SIS = new PictureBox();
            labelVarA_SIS = new Label();
            textBoxVarA_SIS = new TextBox();
            labelResult_SIS = new Label();
            textBoxResult_SIS = new TextBox();
            buttonDone_SIS = new Button();
            buttonInfo_SIS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SIS).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFormula_SIS
            // 
            pictureBoxFormula_SIS.Location = new Point(16, 18);
            pictureBoxFormula_SIS.Margin = new Padding(4, 5, 4, 5);
            pictureBoxFormula_SIS.Name = "pictureBoxFormula_SIS";
            pictureBoxFormula_SIS.Size = new Size(373, 123);
            pictureBoxFormula_SIS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFormula_SIS.TabIndex = 0;
            pictureBoxFormula_SIS.TabStop = false;
            // 
            // labelVarA_SIS
            // 
            labelVarA_SIS.AutoSize = true;
            labelVarA_SIS.Location = new Point(16, 169);
            labelVarA_SIS.Margin = new Padding(4, 0, 4, 0);
            labelVarA_SIS.Name = "labelVarA_SIS";
            labelVarA_SIS.Size = new Size(107, 20);
            labelVarA_SIS.TabIndex = 1;
            labelVarA_SIS.Text = "Введите X = 2:";
            // 
            // textBoxVarA_SIS
            // 
            textBoxVarA_SIS.Location = new Point(137, 165);
            textBoxVarA_SIS.Margin = new Padding(4, 5, 4, 5);
            textBoxVarA_SIS.Name = "textBoxVarA_SIS";
            textBoxVarA_SIS.Size = new Size(132, 27);
            textBoxVarA_SIS.TabIndex = 2;
            textBoxVarA_SIS.Text = "2";
            // 
            // labelResult_SIS
            // 
            labelResult_SIS.AutoSize = true;
            labelResult_SIS.Location = new Point(16, 231);
            labelResult_SIS.Margin = new Padding(4, 0, 4, 0);
            labelResult_SIS.Name = "labelResult_SIS";
            labelResult_SIS.Size = new Size(78, 20);
            labelResult_SIS.TabIndex = 3;
            labelResult_SIS.Text = "Результат:";
            // 
            // textBoxResult_SIS
            // 
            textBoxResult_SIS.Location = new Point(137, 226);
            textBoxResult_SIS.Margin = new Padding(4, 5, 4, 5);
            textBoxResult_SIS.Name = "textBoxResult_SIS";
            textBoxResult_SIS.ReadOnly = true;
            textBoxResult_SIS.Size = new Size(132, 27);
            textBoxResult_SIS.TabIndex = 4;
            // 
            // buttonDone_SIS
            // 
            buttonDone_SIS.Location = new Point(293, 162);
            buttonDone_SIS.Margin = new Padding(4, 5, 4, 5);
            buttonDone_SIS.Name = "buttonDone_SIS";
            buttonDone_SIS.Size = new Size(100, 35);
            buttonDone_SIS.TabIndex = 5;
            buttonDone_SIS.Text = "Выполнить";
            buttonDone_SIS.UseVisualStyleBackColor = true;
            buttonDone_SIS.Click += buttonDone_SIS_Click;
            // 
            // buttonInfo_SIS
            // 
            buttonInfo_SIS.Location = new Point(293, 223);
            buttonInfo_SIS.Margin = new Padding(4, 5, 4, 5);
            buttonInfo_SIS.Name = "buttonInfo_SIS";
            buttonInfo_SIS.Size = new Size(100, 35);
            buttonInfo_SIS.TabIndex = 6;
            buttonInfo_SIS.Text = "Справка";
            buttonInfo_SIS.UseVisualStyleBackColor = true;
            buttonInfo_SIS.Click += buttonInfo_SIS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 292);
            Controls.Add(buttonInfo_SIS);
            Controls.Add(buttonDone_SIS);
            Controls.Add(textBoxResult_SIS);
            Controls.Add(labelResult_SIS);
            Controls.Add(textBoxVarA_SIS);
            Controls.Add(labelVarA_SIS);
            Controls.Add(pictureBoxFormula_SIS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6. Таск 0. Вариант 22";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SIS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFormula_SIS;
        private System.Windows.Forms.Label labelVarA_SIS;
        private System.Windows.Forms.TextBox textBoxVarA_SIS;
        private System.Windows.Forms.Label labelResult_SIS;
        private System.Windows.Forms.TextBox textBoxResult_SIS;
        private System.Windows.Forms.Button buttonDone_SIS;
        private System.Windows.Forms.Button buttonInfo_SIS;
    }
}