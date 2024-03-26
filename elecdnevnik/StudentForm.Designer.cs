namespace elecdnevnik
{
    partial class StudentForm
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
            this.btnrasp = new System.Windows.Forms.Button();
            this.btnvozr1 = new System.Windows.Forms.Button();
            this.btnocen = new System.Windows.Forms.Button();
            this.btnkab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnrasp
            // 
            this.btnrasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnrasp.Location = new System.Drawing.Point(38, 23);
            this.btnrasp.Name = "btnrasp";
            this.btnrasp.Size = new System.Drawing.Size(178, 79);
            this.btnrasp.TabIndex = 0;
            this.btnrasp.Text = "Расписание";
            this.btnrasp.UseVisualStyleBackColor = true;
            this.btnrasp.Click += new System.EventHandler(this.btnrasp_Click);
            // 
            // btnvozr1
            // 
            this.btnvozr1.Location = new System.Drawing.Point(338, 1);
            this.btnvozr1.Name = "btnvozr1";
            this.btnvozr1.Size = new System.Drawing.Size(111, 47);
            this.btnvozr1.TabIndex = 1;
            this.btnvozr1.Text = "Сменить пользователя";
            this.btnvozr1.UseVisualStyleBackColor = true;
            this.btnvozr1.Click += new System.EventHandler(this.btnvozr1_Click);
            // 
            // btnocen
            // 
            this.btnocen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnocen.Location = new System.Drawing.Point(38, 136);
            this.btnocen.Name = "btnocen";
            this.btnocen.Size = new System.Drawing.Size(178, 79);
            this.btnocen.TabIndex = 2;
            this.btnocen.Text = "Оценки";
            this.btnocen.UseVisualStyleBackColor = true;
            this.btnocen.Click += new System.EventHandler(this.btnocen_Click_1);
            // 
            // btnkab
            // 
            this.btnkab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnkab.Location = new System.Drawing.Point(246, 77);
            this.btnkab.Name = "btnkab";
            this.btnkab.Size = new System.Drawing.Size(178, 79);
            this.btnkab.TabIndex = 3;
            this.btnkab.Text = "Личный кабинет";
            this.btnkab.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 239);
            this.Controls.Add(this.btnkab);
            this.Controls.Add(this.btnocen);
            this.Controls.Add(this.btnvozr1);
            this.Controls.Add(this.btnrasp);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnrasp;
        private System.Windows.Forms.Button btnvozr1;
        private System.Windows.Forms.Button btnocen;
        private System.Windows.Forms.Button btnkab;
    }
}