namespace elecdnevnik
{
    partial class Raspform
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
            this.btnmon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnvtor = new System.Windows.Forms.Button();
            this.btnsr = new System.Windows.Forms.Button();
            this.btnchet = new System.Windows.Forms.Button();
            this.btnpyat = new System.Windows.Forms.Button();
            this.btnsyb = new System.Windows.Forms.Button();
            this.btnvozr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmon
            // 
            this.btnmon.Location = new System.Drawing.Point(7, 7);
            this.btnmon.Name = "btnmon";
            this.btnmon.Size = new System.Drawing.Size(125, 34);
            this.btnmon.TabIndex = 0;
            this.btnmon.Text = "Понедельник";
            this.btnmon.UseVisualStyleBackColor = true;
            this.btnmon.Click += new System.EventHandler(this.btnmon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 46;
            this.dataGridView1.Location = new System.Drawing.Point(47, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(718, 366);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnvtor
            // 
            this.btnvtor.Location = new System.Drawing.Point(138, 7);
            this.btnvtor.Name = "btnvtor";
            this.btnvtor.Size = new System.Drawing.Size(125, 34);
            this.btnvtor.TabIndex = 2;
            this.btnvtor.Text = "Вторник";
            this.btnvtor.UseVisualStyleBackColor = true;
            this.btnvtor.Click += new System.EventHandler(this.btnvtor_Click);
            // 
            // btnsr
            // 
            this.btnsr.Location = new System.Drawing.Point(269, 7);
            this.btnsr.Name = "btnsr";
            this.btnsr.Size = new System.Drawing.Size(125, 34);
            this.btnsr.TabIndex = 3;
            this.btnsr.Text = "Среда";
            this.btnsr.UseVisualStyleBackColor = true;
            this.btnsr.Click += new System.EventHandler(this.btnsr_Click);
            // 
            // btnchet
            // 
            this.btnchet.Location = new System.Drawing.Point(400, 7);
            this.btnchet.Name = "btnchet";
            this.btnchet.Size = new System.Drawing.Size(125, 34);
            this.btnchet.TabIndex = 4;
            this.btnchet.Text = "Четверг";
            this.btnchet.UseVisualStyleBackColor = true;
            this.btnchet.Click += new System.EventHandler(this.btnchet_Click);
            // 
            // btnpyat
            // 
            this.btnpyat.Location = new System.Drawing.Point(531, 7);
            this.btnpyat.Name = "btnpyat";
            this.btnpyat.Size = new System.Drawing.Size(125, 34);
            this.btnpyat.TabIndex = 5;
            this.btnpyat.Text = "Пятница";
            this.btnpyat.UseVisualStyleBackColor = true;
            this.btnpyat.Click += new System.EventHandler(this.btnpyat_Click);
            // 
            // btnsyb
            // 
            this.btnsyb.Location = new System.Drawing.Point(662, 7);
            this.btnsyb.Name = "btnsyb";
            this.btnsyb.Size = new System.Drawing.Size(134, 34);
            this.btnsyb.TabIndex = 6;
            this.btnsyb.Text = "Суббота";
            this.btnsyb.UseVisualStyleBackColor = true;
            this.btnsyb.Click += new System.EventHandler(this.btnsyb_Click);
            // 
            // btnvozr
            // 
            this.btnvozr.Location = new System.Drawing.Point(662, 419);
            this.btnvozr.Name = "btnvozr";
            this.btnvozr.Size = new System.Drawing.Size(126, 29);
            this.btnvozr.TabIndex = 7;
            this.btnvozr.Text = "Вернуться назад";
            this.btnvozr.UseVisualStyleBackColor = true;
            this.btnvozr.Click += new System.EventHandler(this.btnvozr_Click);
            // 
            // Raspform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvozr);
            this.Controls.Add(this.btnsyb);
            this.Controls.Add(this.btnpyat);
            this.Controls.Add(this.btnchet);
            this.Controls.Add(this.btnsr);
            this.Controls.Add(this.btnvtor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnmon);
            this.Name = "Raspform";
            this.Text = "Raspform";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnvtor;
        private System.Windows.Forms.Button btnsr;
        private System.Windows.Forms.Button btnchet;
        private System.Windows.Forms.Button btnpyat;
        private System.Windows.Forms.Button btnsyb;
        private System.Windows.Forms.Button btnvozr;
    }
}