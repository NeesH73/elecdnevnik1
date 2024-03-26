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
            this.btReturn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.loginSave = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grpNumbSave = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.fullNameSave = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.subjSave = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.exTypeSave = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gradeSave = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dateSave = new System.Windows.Forms.CheckBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpd = new System.Windows.Forms.Button();
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
            this.button1.Location = new System.Drawing.Point(946, 656);
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
            this.btReturn.Location = new System.Drawing.Point(1375, 720);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(163, 47);
            this.btReturn.TabIndex = 14;
            this.btReturn.Text = "Назад";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(984, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Дата";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(946, 596);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(155, 31);
            this.tbDate.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(961, 564);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "ДД.ММ.ГГ";
            // 
            // loginSave
            // 
            this.loginSave.AutoSize = true;
            this.loginSave.Location = new System.Drawing.Point(12, 594);
            this.loginSave.Name = "loginSave";
            this.loginSave.Size = new System.Drawing.Size(28, 27);
            this.loginSave.TabIndex = 18;
            this.loginSave.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 564);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "сохр.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 650);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "сохр.";
            // 
            // grpNumbSave
            // 
            this.grpNumbSave.AutoSize = true;
            this.grpNumbSave.Location = new System.Drawing.Point(12, 680);
            this.grpNumbSave.Name = "grpNumbSave";
            this.grpNumbSave.Size = new System.Drawing.Size(28, 27);
            this.grpNumbSave.TabIndex = 20;
            this.grpNumbSave.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 566);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "сохр.";
            // 
            // fullNameSave
            // 
            this.fullNameSave.AutoSize = true;
            this.fullNameSave.Location = new System.Drawing.Point(259, 596);
            this.fullNameSave.Name = "fullNameSave";
            this.fullNameSave.Size = new System.Drawing.Size(28, 27);
            this.fullNameSave.TabIndex = 22;
            this.fullNameSave.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 654);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "сохр.";
            // 
            // subjSave
            // 
            this.subjSave.AutoSize = true;
            this.subjSave.Location = new System.Drawing.Point(259, 684);
            this.subjSave.Name = "subjSave";
            this.subjSave.Size = new System.Drawing.Size(28, 27);
            this.subjSave.TabIndex = 24;
            this.subjSave.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(652, 569);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 25);
            this.label13.TabIndex = 27;
            this.label13.Text = "сохр.";
            // 
            // exTypeSave
            // 
            this.exTypeSave.AutoSize = true;
            this.exTypeSave.Location = new System.Drawing.Point(663, 599);
            this.exTypeSave.Name = "exTypeSave";
            this.exTypeSave.Size = new System.Drawing.Size(28, 27);
            this.exTypeSave.TabIndex = 26;
            this.exTypeSave.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(652, 653);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "сохр.";
            // 
            // gradeSave
            // 
            this.gradeSave.AutoSize = true;
            this.gradeSave.Location = new System.Drawing.Point(663, 683);
            this.gradeSave.Name = "gradeSave";
            this.gradeSave.Size = new System.Drawing.Size(28, 27);
            this.gradeSave.TabIndex = 28;
            this.gradeSave.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(891, 570);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "сохр.";
            // 
            // dateSave
            // 
            this.dateSave.AutoSize = true;
            this.dateSave.Location = new System.Drawing.Point(912, 598);
            this.dateSave.Name = "dateSave";
            this.dateSave.Size = new System.Drawing.Size(28, 27);
            this.dateSave.TabIndex = 30;
            this.dateSave.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(1378, 549);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(139, 41);
            this.btDelete.TabIndex = 32;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpd
            // 
            this.btUpd.Location = new System.Drawing.Point(1138, 548);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(184, 41);
            this.btUpd.TabIndex = 33;
            this.btUpd.Text = "Редактировать";
            this.btUpd.UseVisualStyleBackColor = true;
            this.btUpd.Click += new System.EventHandler(this.btUpd_Click);
            // 
            // ExamGradeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 779);
            this.Controls.Add(this.btUpd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateSave);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.gradeSave);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.exTypeSave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.subjSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.fullNameSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpNumbSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.loginSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDate);
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
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox loginSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox grpNumbSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox fullNameSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox subjSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox exTypeSave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox gradeSave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox dateSave;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpd;
    }
}