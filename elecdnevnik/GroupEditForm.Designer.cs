namespace elecdnevnik
{
    partial class GroupEditForm
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
            this.btBack = new System.Windows.Forms.Button();
            this.StudentGW = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGroupNumb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGW)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(12, 771);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(135, 65);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // StudentGW
            // 
            this.StudentGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGW.Location = new System.Drawing.Point(-12, 12);
            this.StudentGW.Name = "StudentGW";
            this.StudentGW.RowHeadersWidth = 82;
            this.StudentGW.RowTemplate.Height = 33;
            this.StudentGW.Size = new System.Drawing.Size(1476, 507);
            this.StudentGW.TabIndex = 1;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(650, 559);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(134, 72);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(101, 552);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(169, 31);
            this.tbLogin.TabIndex = 4;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(101, 600);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(169, 31);
            this.tbPass.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // tbGroupNumb
            // 
            this.tbGroupNumb.Location = new System.Drawing.Point(423, 555);
            this.tbGroupNumb.Name = "tbGroupNumb";
            this.tbGroupNumb.Size = new System.Drawing.Size(184, 31);
            this.tbGroupNumb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 558);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "№Группы";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(423, 600);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(184, 31);
            this.tbFullName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 603);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "ФИО";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(1332, 780);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(132, 72);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpd
            // 
            this.btUpd.Location = new System.Drawing.Point(790, 558);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(138, 73);
            this.btUpd.TabIndex = 12;
            this.btUpd.Text = "Редактировать";
            this.btUpd.UseVisualStyleBackColor = true;
            this.btUpd.Click += new System.EventHandler(this.btUpd_Click);
            // 
            // GroupEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 848);
            this.Controls.Add(this.btUpd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGroupNumb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.StudentGW);
            this.Controls.Add(this.btBack);
            this.Name = "GroupEditForm";
            this.Text = "GroupEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.StudentGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataGridView StudentGW;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGroupNumb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpd;
    }
}