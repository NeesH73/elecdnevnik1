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
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `exam` ( `login`, `subject`, `groupNumb`, `fullName`, `examType`, `grade`, `date`) VALUES(@login, @subj, @grpNumb, @name, @exT, @g, @d)", db.GetConnection());
            if (tbLogin.Text == "" || tbGrade.Text == "" || tbGrpNumb.Text == "" || tbFullName.Text == "" || tbSubject.Text == "" || cbExamType.Text == "" || tbDate.Text == "")
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
                    cmd.Parameters.Add("@d", MySqlDbType.VarChar).Value = tbDate.Text;
                    db.OpenConnection();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        if (fullNameSave.Checked)
                        {

                        }
                        else
                        {
                            tbFullName.Clear();
                        }
                        if (gradeSave.Checked)
                        {

                        }
                        else
                        {
                            tbGrade.Clear();
                        }
                        if (loginSave.Checked)
                        {

                        }
                        else
                        {
                            tbLogin.Clear();
                        }
                        if (subjSave.Checked)
                        {

                        }
                        else
                        {
                            tbSubject.Clear();
                        }
                        if (grpNumbSave.Checked)
                        {

                        }
                        else
                        {
                            tbGrpNumb.Clear();
                        }
                        if (exTypeSave.Checked)
                        {

                        }
                        else
                        {
                            cbExamType.Text.DefaultIfEmpty();
                        }
                        if (dateSave.Checked)
                        {

                        }
                        else
                        {
                            tbDate.Clear();
                        }

                        MessageBox.Show("Оценка поставлена.");
                        refreshGW();
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка!");
                    }

                    db.CloseConnection();
                    
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("Неверный формат ввода даты");

                    tbDate.Clear();

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

        private void btUpd_Click(object sender, EventArgs e)
        {
            if (examGradeGW.SelectedRows.Count > 0)
            {
                DataGridViewRow row = examGradeGW.SelectedRows[0];

                string id = row.Cells["id"].Value?.ToString() ?? string.Empty;
                string groupNumb = row.Cells["groupNumb"].Value?.ToString() ?? string.Empty;
                string login = row.Cells["login"].Value?.ToString() ?? string.Empty;
                string fullName = row.Cells["fullName"].Value?.ToString() ?? string.Empty;
                string subject = row.Cells["subject"].Value?.ToString() ?? string.Empty;
                string extype = row.Cells["examType"].Value?.ToString() ?? string.Empty;
                string date = row.Cells["date"].Value?.ToString() ?? string.Empty;
                string grade = row.Cells["grade"].Value?.ToString() ?? string.Empty;


                dbconnect db = new dbconnect();
                MySqlCommand cmd = new MySqlCommand("UPDATE `exam` SET `login` = @login, `subject` = @sub, `groupNumb` = @grpNumb, `fullName` = @name, `examType` = @ex, `grade` = @gr, `date` = @d WHERE `ID` = @id", db.GetConnection());
                try
                {
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                    cmd.Parameters.Add("@sub", MySqlDbType.VarChar).Value = subject;
                    cmd.Parameters.Add("@grpNumb", MySqlDbType.VarChar).Value = groupNumb;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = fullName;
                    cmd.Parameters.Add("@gr", MySqlDbType.VarChar).Value = grade;
                    cmd.Parameters.Add("@d", MySqlDbType.Date).Value = date;
                    cmd.Parameters.Add("@ex", MySqlDbType.VarChar).Value = extype;

                    db.OpenConnection();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        refreshGW();
                        MessageBox.Show("Данные обновлены");
                        
                    }
                    else
                    {
                        refreshGW();
                        MessageBox.Show("Вы не можете редактировать id");
                    }
                    db.CloseConnection();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("ID должен быть уникальным!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Выберите другую строку");
                }
                
            }
            else
            {
                MessageBox.Show("Выберите строку для обновления");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (examGradeGW.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранные записи?", "Удаление записей", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in examGradeGW.SelectedRows)
                    {
                        string id = row.Cells["id"].Value?.ToString() ?? string.Empty;


                        dbconnect db = new dbconnect();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM `exam` WHERE `ID` = @id", db.GetConnection());
                        cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                        db.OpenConnection();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Запись удалена успешно");
                        }
                        else
                        {
                            MessageBox.Show("Выберите другую строку");
                        }
                        db.CloseConnection();
                    }


                    refreshGW();
                }
            }
            else
            {
                MessageBox.Show("Выберите записи для удаления");
            }
        }
    }
}
    

