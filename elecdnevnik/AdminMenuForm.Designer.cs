namespace elecdnevnik
{
    partial class AdminMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuForm));
            this.btGroupEdit = new System.Windows.Forms.Button();
            this.btScheduleEdit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGroupEdit
            // 
            this.btGroupEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btGroupEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGroupEdit.Location = new System.Drawing.Point(35, 88);
            this.btGroupEdit.Name = "btGroupEdit";
            this.btGroupEdit.Size = new System.Drawing.Size(309, 113);
            this.btGroupEdit.TabIndex = 0;
            this.btGroupEdit.Text = "Редакт. уч. групп";
            this.btGroupEdit.UseVisualStyleBackColor = false;
            this.btGroupEdit.Click += new System.EventHandler(this.btGroupEdit_Click);
            // 
            // btScheduleEdit
            // 
            this.btScheduleEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btScheduleEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btScheduleEdit.Location = new System.Drawing.Point(369, 88);
            this.btScheduleEdit.Name = "btScheduleEdit";
            this.btScheduleEdit.Size = new System.Drawing.Size(309, 113);
            this.btScheduleEdit.TabIndex = 1;
            this.btScheduleEdit.Text = "Редакт. расписания";
            this.btScheduleEdit.UseVisualStyleBackColor = false;
            this.btScheduleEdit.Click += new System.EventHandler(this.btScheduleEdit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(205, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(309, 113);
            this.button3.TabIndex = 2;
            this.button3.Text = "Проставление баллов";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ExamGradeAdd);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Tomato;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Location = new System.Drawing.Point(629, 567);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(131, 56);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сменить пользователя";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.return_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(772, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btScheduleEdit);
            this.Controls.Add(this.btGroupEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню Администратора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGroupEdit;
        private System.Windows.Forms.Button btScheduleEdit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button button1;
    }
}