namespace elecdnevnik
{
    partial class ScheduleEditForm
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
            this.scheduleGW = new System.Windows.Forms.DataGridView();
            this.btMonday = new System.Windows.Forms.Button();
            this.btTuesday = new System.Windows.Forms.Button();
            this.btWednesday = new System.Windows.Forms.Button();
            this.btThursday = new System.Windows.Forms.Button();
            this.btFriday = new System.Windows.Forms.Button();
            this.btSaturday = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGroupNumb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDayOfWeek = new System.Windows.Forms.ComboBox();
            this.btBack = new System.Windows.Forms.Button();
            this.cbTime = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGW)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleGW
            // 
            this.scheduleGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleGW.Location = new System.Drawing.Point(4, 91);
            this.scheduleGW.Name = "scheduleGW";
            this.scheduleGW.RowHeadersWidth = 82;
            this.scheduleGW.RowTemplate.Height = 33;
            this.scheduleGW.Size = new System.Drawing.Size(1062, 418);
            this.scheduleGW.TabIndex = 0;
            // 
            // btMonday
            // 
            this.btMonday.Location = new System.Drawing.Point(4, 13);
            this.btMonday.Name = "btMonday";
            this.btMonday.Size = new System.Drawing.Size(164, 48);
            this.btMonday.TabIndex = 1;
            this.btMonday.Text = "Понедельник";
            this.btMonday.UseVisualStyleBackColor = true;
            this.btMonday.Click += new System.EventHandler(this.btMonday_Click);
            this.btMonday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMonday_MouseDown);
            // 
            // btTuesday
            // 
            this.btTuesday.Location = new System.Drawing.Point(174, 12);
            this.btTuesday.Name = "btTuesday";
            this.btTuesday.Size = new System.Drawing.Size(164, 48);
            this.btTuesday.TabIndex = 2;
            this.btTuesday.Text = "Вторник";
            this.btTuesday.UseVisualStyleBackColor = true;
            this.btTuesday.Click += new System.EventHandler(this.btTuesday_Click);
            this.btTuesday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btTuesday_MouseDown);
            // 
            // btWednesday
            // 
            this.btWednesday.Location = new System.Drawing.Point(344, 13);
            this.btWednesday.Name = "btWednesday";
            this.btWednesday.Size = new System.Drawing.Size(164, 48);
            this.btWednesday.TabIndex = 3;
            this.btWednesday.Text = "Среда";
            this.btWednesday.UseVisualStyleBackColor = true;
            this.btWednesday.Click += new System.EventHandler(this.btWednesday_Click);
            this.btWednesday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btWednesday_MouseDown);
            // 
            // btThursday
            // 
            this.btThursday.Location = new System.Drawing.Point(514, 13);
            this.btThursday.Name = "btThursday";
            this.btThursday.Size = new System.Drawing.Size(164, 48);
            this.btThursday.TabIndex = 4;
            this.btThursday.Text = "Четверг";
            this.btThursday.UseVisualStyleBackColor = true;
            this.btThursday.Click += new System.EventHandler(this.btThursday_Click);
            this.btThursday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btThursday_MouseDown);
            // 
            // btFriday
            // 
            this.btFriday.Location = new System.Drawing.Point(684, 12);
            this.btFriday.Name = "btFriday";
            this.btFriday.Size = new System.Drawing.Size(164, 48);
            this.btFriday.TabIndex = 5;
            this.btFriday.Text = "Пятница";
            this.btFriday.UseVisualStyleBackColor = true;
            this.btFriday.Click += new System.EventHandler(this.btFriday_Click);
            this.btFriday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btFriday_MouseDown);
            // 
            // btSaturday
            // 
            this.btSaturday.Location = new System.Drawing.Point(854, 12);
            this.btSaturday.Name = "btSaturday";
            this.btSaturday.Size = new System.Drawing.Size(164, 48);
            this.btSaturday.TabIndex = 6;
            this.btSaturday.Text = "Суббота";
            this.btSaturday.UseVisualStyleBackColor = true;
            this.btSaturday.Click += new System.EventHandler(this.btSaturday_Click);
            this.btSaturday.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btSaturday_MouseDown);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(1143, 465);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(157, 53);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(4, 538);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(201, 53);
            this.btEdit.TabIndex = 8;
            this.btEdit.Text = "Редактировать";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(1216, 692);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(157, 53);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1181, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "№Группы";
            // 
            // tbGroupNumb
            // 
            this.tbGroupNumb.Location = new System.Drawing.Point(1106, 221);
            this.tbGroupNumb.Name = "tbGroupNumb";
            this.tbGroupNumb.Size = new System.Drawing.Size(267, 31);
            this.tbGroupNumb.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1195, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Время";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(1106, 406);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(267, 31);
            this.tbSubject.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1181, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Предмет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1168, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "День недели";
            // 
            // cbDayOfWeek
            // 
            this.cbDayOfWeek.FormattingEnabled = true;
            this.cbDayOfWeek.Items.AddRange(new object[] {
            "monday",
            "tuesday",
            "wednesday",
            "thursday",
            "friday",
            "saturday"});
            this.cbDayOfWeek.Location = new System.Drawing.Point(1130, 128);
            this.cbDayOfWeek.Name = "cbDayOfWeek";
            this.cbDayOfWeek.Size = new System.Drawing.Size(207, 33);
            this.cbDayOfWeek.TabIndex = 18;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(12, 701);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(141, 53);
            this.btBack.TabIndex = 19;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "8:30-10:00",
            "10:10-11:40",
            "12:10-13:40",
            "13:50-15:20",
            "15:30-17:00"});
            this.cbTime.Location = new System.Drawing.Point(1106, 305);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(267, 33);
            this.cbTime.TabIndex = 20;
            // 
            // ScheduleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 757);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.cbDayOfWeek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGroupNumb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btSaturday);
            this.Controls.Add(this.btFriday);
            this.Controls.Add(this.btThursday);
            this.Controls.Add(this.btWednesday);
            this.Controls.Add(this.btTuesday);
            this.Controls.Add(this.btMonday);
            this.Controls.Add(this.scheduleGW);
            this.Name = "ScheduleEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scheduleGW;
        private System.Windows.Forms.Button btMonday;
        private System.Windows.Forms.Button btTuesday;
        private System.Windows.Forms.Button btWednesday;
        private System.Windows.Forms.Button btThursday;
        private System.Windows.Forms.Button btFriday;
        private System.Windows.Forms.Button btSaturday;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGroupNumb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDayOfWeek;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.ComboBox cbTime;
    }
}