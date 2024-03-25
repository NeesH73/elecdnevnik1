using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elecdnevnik
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            
        }

        private void btnrasp_Click(object sender, EventArgs e)
        {
            Raspform form3 = new Raspform();
            form3.Show();
            this.Hide();
        }

        private void btnvozr1_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }
    }
}
