namespace Tyuiu.DmitrievLR.Sprint7.Project.V9
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 1;
            label1.Text = "Разработчик: Дмитриев Л.Р.";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 2;
            label2.Text = "Группа: ИИПб-24-1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 56);
            label3.Name = "label3";
            label3.Size = new Size(302, 15);
            label3.TabIndex = 3;
            label3.Text = "Программа разработана в рамках изучения языка C#";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(283, 15);
            label4.TabIndex = 4;
            label4.Text = "Тюменский индустриальный университет (с) 2024";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 172);
            label5.Name = "label5";
            label5.Size = new Size(262, 15);
            label5.TabIndex = 5;
            label5.Text = "Высшая школа цифровых технологий (с) 2024";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 105);
            label6.Name = "label6";
            label6.Size = new Size(193, 15);
            label6.TabIndex = 6;
            label6.Text = "Tyuiu.DmitrievLR.Sprint7.Project.V9";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(426, 236);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(101, 25);
            buttonOk.TabIndex = 7;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 274);
            Controls.Add(buttonOk);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonOk;
    }
}