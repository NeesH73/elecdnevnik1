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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.btnrasp = new System.Windows.Forms.Button();
            this.btnvozr1 = new System.Windows.Forms.Button();
            this.btnocen = new System.Windows.Forms.Button();
            this.btnkab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnrasp
            // 
            this.btnrasp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnrasp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnrasp.Location = new System.Drawing.Point(76, 44);
            this.btnrasp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnrasp.Name = "btnrasp";
            this.btnrasp.Size = new System.Drawing.Size(356, 152);
            this.btnrasp.TabIndex = 0;
            this.btnrasp.Text = "Расписание";
            this.btnrasp.UseVisualStyleBackColor = false;
            this.btnrasp.Click += new System.EventHandler(this.btnrasp_Click);
            // 
            // btnvozr1
            // 
            this.btnvozr1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnvozr1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvozr1.Location = new System.Drawing.Point(676, 2);
            this.btnvozr1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnvozr1.Name = "btnvozr1";
            this.btnvozr1.Size = new System.Drawing.Size(222, 90);
            this.btnvozr1.TabIndex = 1;
            this.btnvozr1.Text = "Сменить пользователя";
            this.btnvozr1.UseVisualStyleBackColor = false;
            this.btnvozr1.Click += new System.EventHandler(this.btnvozr1_Click);
            // 
            // btnocen
            // 
            this.btnocen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnocen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnocen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnocen.Location = new System.Drawing.Point(76, 262);
            this.btnocen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnocen.Name = "btnocen";
            this.btnocen.Size = new System.Drawing.Size(356, 152);
            this.btnocen.TabIndex = 2;
            this.btnocen.Text = "Оценки";
            this.btnocen.UseVisualStyleBackColor = false;
            this.btnocen.Click += new System.EventHandler(this.btnocen_Click_1);
            // 
            // btnkab
            // 
            this.btnkab.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnkab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnkab.Location = new System.Drawing.Point(492, 148);
            this.btnkab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnkab.Name = "btnkab";
            this.btnkab.Size = new System.Drawing.Size(356, 152);
            this.btnkab.TabIndex = 3;
            this.btnkab.Text = "Личный кабинет";
            this.btnkab.UseVisualStyleBackColor = false;
            this.btnkab.Click += new System.EventHandler(this.btnkab_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(900, 460);
            this.Controls.Add(this.btnkab);
            this.Controls.Add(this.btnocen);
            this.Controls.Add(this.btnvozr1);
            this.Controls.Add(this.btnrasp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnrasp;
        private System.Windows.Forms.Button btnvozr1;
        private System.Windows.Forms.Button btnocen;
        private System.Windows.Forms.Button btnkab;
    }
}