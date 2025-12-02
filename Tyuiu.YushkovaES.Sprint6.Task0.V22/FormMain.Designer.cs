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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxFormula_SIS = new System.Windows.Forms.PictureBox();
            this.labelVarA_SIS = new System.Windows.Forms.Label();
            this.textBoxVarA_SIS = new System.Windows.Forms.TextBox();
            this.labelResult_SIS = new System.Windows.Forms.Label();
            this.textBoxResult_SIS = new System.Windows.Forms.TextBox();
            this.buttonDone_SIS = new System.Windows.Forms.Button();
            this.buttonInfo_SIS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SIS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFormula_SIS
            // 
            this.pictureBoxFormula_SIS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_SIS.Image")));
            this.pictureBoxFormula_SIS.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFormula_SIS.Name = "pictureBoxFormula_SIS";
            this.pictureBoxFormula_SIS.Size = new System.Drawing.Size(280, 80);
            this.pictureBoxFormula_SIS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFormula_SIS.TabIndex = 0;
            this.pictureBoxFormula_SIS.TabStop = false;
            // 
            // labelVarA_SIS
            // 
            this.labelVarA_SIS.AutoSize = true;
            this.labelVarA_SIS.Location = new System.Drawing.Point(12, 110);
            this.labelVarA_SIS.Name = "labelVarA_SIS";
            this.labelVarA_SIS.Size = new System.Drawing.Size(85, 13);
            this.labelVarA_SIS.TabIndex = 1;
            this.labelVarA_SIS.Text = "Введите X = 2:";
            // 
            // textBoxVarA_SIS
            // 
            this.textBoxVarA_SIS.Location = new System.Drawing.Point(103, 107);
            this.textBoxVarA_SIS.Name = "textBoxVarA_SIS";
            this.textBoxVarA_SIS.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarA_SIS.TabIndex = 2;
            this.textBoxVarA_SIS.Text = "2";
            // 
            // labelResult_SIS
            // 
            this.labelResult_SIS.AutoSize = true;
            this.labelResult_SIS.Location = new System.Drawing.Point(12, 150);
            this.labelResult_SIS.Name = "labelResult_SIS";
            this.labelResult_SIS.Size = new System.Drawing.Size(65, 13);
            this.labelResult_SIS.TabIndex = 3;
            this.labelResult_SIS.Text = "Результат:";
            // 
            // textBoxResult_SIS
            // 
            this.textBoxResult_SIS.Location = new System.Drawing.Point(103, 147);
            this.textBoxResult_SIS.Name = "textBoxResult_SIS";
            this.textBoxResult_SIS.ReadOnly = true;
            this.textBoxResult_SIS.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_SIS.TabIndex = 4;
            // 
            // buttonDone_SIS
            // 
            this.buttonDone_SIS.Location = new System.Drawing.Point(220, 105);
            this.buttonDone_SIS.Name = "buttonDone_SIS";
            this.buttonDone_SIS.Size = new System.Drawing.Size(75, 23);
            this.buttonDone_SIS.TabIndex = 5;
            this.buttonDone_SIS.Text = "Выполнить";
            this.buttonDone_SIS.UseVisualStyleBackColor = true;
            this.buttonDone_SIS.Click += new System.EventHandler(this.buttonDone_SIS_Click);
            // 
            // buttonInfo_SIS
            // 
            this.buttonInfo_SIS.Location = new System.Drawing.Point(220, 145);
            this.buttonInfo_SIS.Name = "buttonInfo_SIS";
            this.buttonInfo_SIS.Size = new System.Drawing.Size(75, 23);
            this.buttonInfo_SIS.TabIndex = 6;
            this.buttonInfo_SIS.Text = "Справка";
            this.buttonInfo_SIS.UseVisualStyleBackColor = true;
            this.buttonInfo_SIS.Click += new System.EventHandler(this.buttonInfo_SIS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 190);
            this.Controls.Add(this.buttonInfo_SIS);
            this.Controls.Add(this.buttonDone_SIS);
            this.Controls.Add(this.textBoxResult_SIS);
            this.Controls.Add(this.labelResult_SIS);
            this.Controls.Add(this.textBoxVarA_SIS);
            this.Controls.Add(this.labelVarA_SIS);
            this.Controls.Add(this.pictureBoxFormula_SIS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6. Таск 0. Вариант 22";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SIS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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