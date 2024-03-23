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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnrasp
            // 
            this.btnrasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnrasp.Location = new System.Drawing.Point(76, 44);
            this.btnrasp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnrasp.Name = "btnrasp";
            this.btnrasp.Size = new System.Drawing.Size(356, 152);
            this.btnrasp.TabIndex = 0;
            this.btnrasp.Text = "Расписание";
            this.btnrasp.UseVisualStyleBackColor = true;
            this.btnrasp.Click += new System.EventHandler(this.btnrasp_Click);
            // 
            // btnvozr1
            // 
            this.btnvozr1.Location = new System.Drawing.Point(624, 44);
            this.btnvozr1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnvozr1.Name = "btnvozr1";
            this.btnvozr1.Size = new System.Drawing.Size(246, 96);
            this.btnvozr1.TabIndex = 1;
            this.btnvozr1.Text = "Сменить пользователя";
            this.btnvozr1.UseVisualStyleBackColor = true;
            this.btnvozr1.Click += new System.EventHandler(this.btnvozr1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnvozr1);
            this.Controls.Add(this.btnrasp);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnrasp;
        private System.Windows.Forms.Button btnvozr1;
        private System.Windows.Forms.Button button1;
    }
}