namespace elecdnevnik
{
    partial class ExamGradeAddForm
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
            this.components = new System.ComponentModel.Container();
            this.examGradeGW = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGrpNumb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.cbExamType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.examGradeGW)).BeginInit();
            this.SuspendLayout();
            // 
            // examGradeGW
            // 
            this.examGradeGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examGradeGW.Location = new System.Drawing.Point(26, 34);
            this.examGradeGW.Name = "examGradeGW";
            this.examGradeGW.RowHeadersWidth = 82;
            this.examGradeGW.RowTemplate.Height = 33;
            this.examGradeGW.Size = new System.Drawing.Size(1491, 493);
            this.examGradeGW.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1326, 701);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btAdd);
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(62, 594);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(155, 31);
            this.tbLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "№Группы";
            // 
            // tbGrpNumb
            // 
            this.tbGrpNumb.Location = new System.Drawing.Point(62, 680);
            this.tbGrpNumb.Name = "tbGrpNumb";
            this.tbGrpNumb.Size = new System.Drawing.Size(155, 31);
            this.tbGrpNumb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "ФИО";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(293, 594);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(319, 31);
            this.tbFullName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 652);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Предмет";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(293, 680);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(319, 31);
            this.tbSubject.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 643);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Оценка";
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(715, 680);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(155, 31);
            this.tbGrade.TabIndex = 10;
            // 
            // cbExamType
            // 
            this.cbExamType.FormattingEnabled = true;
            this.cbExamType.Items.AddRange(new object[] {
            "Лабораторная работа",
            "Зачет",
            "Экзамен"});
            this.cbExamType.Location = new System.Drawing.Point(715, 594);
            this.cbExamType.Name = "cbExamType";
            this.cbExamType.Size = new System.Drawing.Size(155, 33);
            this.cbExamType.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(719, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Тип экзамена";
            // 
            // btReturn
            // 
            this.btReturn.Location = new System.Drawing.Point(1354, 548);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(163, 47);
            this.btReturn.TabIndex = 14;
            this.btReturn.Text = "Назад";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // ExamGradeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 779);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbExamType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGrpNumb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.examGradeGW);
            this.Name = "ExamGradeAddForm";
            this.Text = "ExamGradeAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.examGradeGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView examGradeGW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGrpNumb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.ComboBox cbExamType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btReturn;
    }
}