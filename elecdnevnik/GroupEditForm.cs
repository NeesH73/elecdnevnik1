using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace elecdnevnik
{
    public partial class GroupEditForm : Form
    {
        private GridView db;
        public GroupEditForm()
        {
            InitializeComponent();
            db = new GridView();
            var quary = "SELECT * FROM user";
            db.MySqlReturnData(quary, StudentGW);

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm admMenu = new AdminMenuForm();
            admMenu.Show();

        }

        public void refreshGW()
        {
            dbconnect db = new dbconnect();
            var sql = "select * from user";
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, db.GetConnection());
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds, "user");
            StudentGW.DataSource = ds.Tables[0];
        }
        private void btAdd_Click(object sender, EventArgs e)
        {

            dbconnect db = new dbconnect();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `user` ( `login`, `pass`, `groupNumb`, `fullName`) VALUES(@login, @pass, @grpNumb, @name)", db.GetConnection());
            if (tbLogin.Text == "" || tbPass.Text == "" || tbGroupNumb.Text == "" || tbFullName.Text == "")
            {
                MessageBox.Show("Вы ввели не все данные.");
            }
            else
            {
                try
                {
                    cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = tbLogin.Text;
                    cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tbPass.Text;
                    cmd.Parameters.Add("@grpNumb", MySqlDbType.VarChar).Value = tbGroupNumb.Text;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = tbFullName.Text;
                    db.OpenConnection();
                    if (cmd.ExecuteNonQuery() == 1)
                    {

                        MessageBox.Show("Студент добавлен");
                        refreshGW();
                        tbGroupNumb.Clear();
                        tbLogin.Clear();
                        tbPass.Clear();
                        tbFullName.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка, студент не был добавлен");
                    }

                    db.CloseConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Студент с таким логином уже существует!");

                    tbLogin.Clear();

                }
            }
        }

       

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (StudentGW.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранные записи?", "Удаление записей", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in StudentGW.SelectedRows)
                    {
                        string id = row.Cells["id"].Value?.ToString() ?? string.Empty;


                        dbconnect db = new dbconnect();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM `user` WHERE `ID` = @id", db.GetConnection());
                        cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                        db.OpenConnection();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Запись удалена успешно");
                        }
                        else
                        {
                            MessageBox.Show("Вы не можете удалить пустую строку");
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

        private void btUpd_Click(object sender, EventArgs e)
        {

            if (StudentGW.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = StudentGW.SelectedRows[0];
                    string id = row.Cells["id"].Value?.ToString() ?? string.Empty;
                    string login = row.Cells["login"].Value?.ToString() ?? string.Empty;
                    string pass = row.Cells["pass"].Value?.ToString() ?? string.Empty;
                    string groupNumb = row.Cells["groupNumb"].Value?.ToString() ?? string.Empty;
                    string fullName = row.Cells["fullName"].Value?.ToString() ?? string.Empty;



                    dbconnect db = new dbconnect();
                    MySqlCommand cmd = new MySqlCommand("UPDATE `user` SET `login` = @login, `pass` = @pass, `groupNumb` = @grpNumb, `fullName` = @name WHERE `ID` = @id", db.GetConnection());

                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                    cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
                    cmd.Parameters.Add("@grpNumb", MySqlDbType.VarChar).Value = groupNumb;
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = fullName;

                    db.OpenConnection();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные обновлены");
                    }
                    else
                    {
                        MessageBox.Show("Вы не можете изменить пустую строку или id");
                    }
                    db.CloseConnection();
                    refreshGW();

 
                }
                
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("ID и логин должны быть уникальны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                refreshGW();
            }
            else
            {
                MessageBox.Show("Выберите строку для обновления");
            }
        }
    }
}





