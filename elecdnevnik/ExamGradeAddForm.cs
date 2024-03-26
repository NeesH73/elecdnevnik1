using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace elecdnevnik
{
    public partial class ExamGradeAddForm : Form
    {
        private GridView db;
        public ExamGradeAddForm()
        {
            InitializeComponent();
            db = new GridView();
            string quary = "SELECT * FROM exam";
            db.MySqlReturnData(quary, examGradeGW);
        }

        private void btAdd(object sender, EventArgs e)
        {
            dbconnect db = new dbconnect();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `exam` ( `login`, `subject`, `groupNumb`, `fullName`, `examType`, `grade`) VALUES(@login, @subj, @grpNumb, @name, @exT, @g)", db.GetConnection());
            if (tbLogin.Text == "" || tbGrade.Text == "" || tbGrpNumb.Text == "" || tbFullName.Text == "" || tbSubject.Text == "" || cbExamType.Text == "")
            {
                MessageBox.Show("Вы ввели не все данные.");
            }
            else
            {
                try
                {
                    cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = tbLogin.Text;
                    cmd.Parameters.Add("@subj", MySqlDbType.VarChar).Value = tbSubject.Text;
                    cmd.Parameters.Add("@grpNumb", MySqlDbType.VarChar).Value = tbGrpNumb.Text;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = tbFullName.Text;
                    cmd.Parameters.Add("@g", MySqlDbType.VarChar).Value = tbGrade.Text;
                    cmd.Parameters.Add("@exT", MySqlDbType.VarChar).Value = cbExamType.Text;
                    db.OpenConnection();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        timer1.Start();
                        MessageBox.Show("Оценка поставлена.");
                        refreshGW();
                        tbGrpNumb.Clear();
                        tbLogin.Clear();
                        tbSubject.Clear();
                        cbExamType.Items.Clear();
                        tbGrade.Clear();
                        tbFullName.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка!");
                    }

                    db.CloseConnection();
                    timer1.Stop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка!");

                    tbLogin.Clear();

                }
            }
        }
        public void refreshGW()
        {
            dbconnect db = new dbconnect();
            string sql = "select * from exam";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, db.GetConnection());
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds, "exam");
            examGradeGW.DataSource = ds.Tables[0];
        }
            private void btReturn_Click(object sender, EventArgs e)
        {
            AdminMenuForm adm = new AdminMenuForm();
            adm.Show();
            this.Hide();
        }
    }
}
    

