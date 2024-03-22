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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void btGroupEdit_Click(object sender, EventArgs e)
        {
           GroupEditForm grpedform = new GroupEditForm();

            grpedform.Show();
            this.Hide();
        }

        
    }
}
