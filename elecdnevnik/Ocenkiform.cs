using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static elecdnevnik.LoginForm;

namespace elecdnevnik
{
    public partial class Ocenkiform : Form
    {
        private GridView db;
        
        public Ocenkiform()
        {
            db = new GridView();
            
            InitializeComponent();
        }

        private void Ocenkiform_Load(object sender, EventArgs e)
        {
            var quary = $"SELECT subject,examType,grade,date FROM exam WHERE login='{LoginForm.UserLogin.loginuser}' ";
            db.MySqlReturnData(quary, dataGridView1);
        }

        private void btnvern_Click_1(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Hide();
        }
    }
}
