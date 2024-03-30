using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace elecdnevnik
{
    public partial class Raspform : Form
    {
        private GridView db;
        public Raspform()
        {
            db = new GridView();
            InitializeComponent();
        }
        
        private void btnmon_Click(object sender, EventArgs e)
        {
            var quary = "SELECT * FROM monday";
            db.MySqlReturnData(quary, dataGridView1);
        }

        private void btnvtor_Click(object sender, EventArgs e)
        {

            var quary = "SELECT * FROM tuesday";
            db.MySqlReturnData(quary, dataGridView1);
        }

        private void btnsr_Click(object sender, EventArgs e)
        {

            var quary = "SELECT * FROM wednesday";
            db.MySqlReturnData(quary, dataGridView1);
        }

        private void btnchet_Click(object sender, EventArgs e)
        {

            var quary = "SELECT * FROM thursday";
            db.MySqlReturnData(quary, dataGridView1);
        }

        private void btnpyat_Click(object sender, EventArgs e)
        {

            var quary = "SELECT * FROM friday";
            db.MySqlReturnData(quary, dataGridView1);
        }

        private void btnsyb_Click(object sender, EventArgs e)
        {

            var quary = "SELECT * FROM saturday";
            db.MySqlReturnData(quary, dataGridView1);
        }

        private void btnvozr_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Hide();
        }

        
    }
}
