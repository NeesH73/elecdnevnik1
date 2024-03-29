namespace elecdnevnik
{
    partial class LichkabinetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichkabinetForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labfio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textboxfio = new System.Windows.Forms.TextBox();
            this.textboxgrup = new System.Windows.Forms.TextBox();
            this.btnvozr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(252, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мой профиль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(344, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО";
            // 
            // labfio
            // 
            this.labfio.AutoSize = true;
            this.labfio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labfio.Location = new System.Drawing.Point(346, 375);
            this.labfio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labfio.Name = "labfio";
            this.labfio.Size = new System.Drawing.Size(0, 36);
            this.labfio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(294, 429);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 44);
            this.label4.TabIndex = 4;
            this.label4.Text = "№ Группы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textboxfio
            // 
            this.textboxfio.Location = new System.Drawing.Point(260, 385);
            this.textboxfio.Margin = new System.Windows.Forms.Padding(6);
            this.textboxfio.Name = "textboxfio";
            this.textboxfio.ReadOnly = true;
            this.textboxfio.Size = new System.Drawing.Size(288, 31);
            this.textboxfio.TabIndex = 5;
            // 
            // textboxgrup
            // 
            this.textboxgrup.Location = new System.Drawing.Point(302, 481);
            this.textboxgrup.Margin = new System.Windows.Forms.Padding(6);
            this.textboxgrup.Name = "textboxgrup";
            this.textboxgrup.ReadOnly = true;
            this.textboxgrup.Size = new System.Drawing.Size(196, 31);
            this.textboxgrup.TabIndex = 6;
            // 
            // btnvozr
            // 
            this.btnvozr.Location = new System.Drawing.Point(616, 23);
            this.btnvozr.Margin = new System.Windows.Forms.Padding(6);
            this.btnvozr.Name = "btnvozr";
            this.btnvozr.Size = new System.Drawing.Size(224, 44);
            this.btnvozr.TabIndex = 7;
            this.btnvozr.Text = "Вернуться назад";
            this.btnvozr.UseVisualStyleBackColor = true;
            this.btnvozr.Click += new System.EventHandler(this.btnvozr_Click);
            // 
            // LichkabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 594);
            this.Controls.Add(this.btnvozr);
            this.Controls.Add(this.textboxgrup);
            this.Controls.Add(this.textboxfio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labfio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LichkabinetForm";
            this.Text = "LichkabinetForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labfio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxfio;
        private System.Windows.Forms.TextBox textboxgrup;
        private System.Windows.Forms.Button btnvozr;
    }
}