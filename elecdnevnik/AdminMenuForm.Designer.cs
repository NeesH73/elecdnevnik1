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
            this.btGroupEdit = new System.Windows.Forms.Button();
            this.btScheduleEdit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGroupEdit
            // 
            this.btGroupEdit.Location = new System.Drawing.Point(35, 88);
            this.btGroupEdit.Name = "btGroupEdit";
            this.btGroupEdit.Size = new System.Drawing.Size(309, 113);
            this.btGroupEdit.TabIndex = 0;
            this.btGroupEdit.Text = "Редакт. уч. групп";
            this.btGroupEdit.UseVisualStyleBackColor = true;
            this.btGroupEdit.Click += new System.EventHandler(this.btGroupEdit_Click);
            // 
            // btScheduleEdit
            // 
            this.btScheduleEdit.Location = new System.Drawing.Point(35, 241);
            this.btScheduleEdit.Name = "btScheduleEdit";
            this.btScheduleEdit.Size = new System.Drawing.Size(309, 113);
            this.btScheduleEdit.TabIndex = 1;
            this.btScheduleEdit.Text = "Редакт. расписания";
            this.btScheduleEdit.UseVisualStyleBackColor = true;
            this.btScheduleEdit.Click += new System.EventHandler(this.btScheduleEdit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(309, 113);
            this.button3.TabIndex = 2;
            this.button3.Text = "Проставление баллов";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(875, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(131, 56);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 635);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btScheduleEdit);
            this.Controls.Add(this.btGroupEdit);
            this.Name = "AdminMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGroupEdit;
        private System.Windows.Forms.Button btScheduleEdit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btExit;
    }
}