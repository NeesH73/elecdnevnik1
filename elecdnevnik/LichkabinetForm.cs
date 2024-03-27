using MySql.Data.MySqlClient;
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
    public partial class LichkabinetForm : Form
    {
        public LichkabinetForm()
        {
            InitializeComponent();
        }

        

        private void btnvozr_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm();
            form.Show();
            this.Hide();

        }

        private void show(object sender, EventArgs e)
        {
            textboxfio.Clear();
            textboxgrup.Clear();
            dbconnect db = new dbconnect();
            string quary = $"SELECT fullName,groupNumb FROM user WHERE login='{LoginForm.UserLogin.loginuser}'";
            MySqlCommand cm = new MySqlCommand(quary, db.GetConnection());
            

            try
            {
                db.OpenConnection();

                using (MySqlDataReader reader = cm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        textboxfio.Text = (reader[0].ToString());
                        textboxgrup.Text = (reader[1].ToString());
                        
                    }
                }
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
    

