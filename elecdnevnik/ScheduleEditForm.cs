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
    public partial class ScheduleEditForm : Form
    {
        private GridView db;
        public ScheduleEditForm()
        {
            InitializeComponent();
            db = new GridView();
        }

        private void btMonday_Click(object sender, EventArgs e)
        {
            string quary = "SELECT * FROM monday";
            db.MySqlReturnData(quary, scheduleGW);
        }

        private void btTuesday_Click(object sender, EventArgs e)
        {
            string quary = "SELECT * FROM tuesday";
            db.MySqlReturnData(quary, scheduleGW);
        }

        private void btWednesday_Click(object sender, EventArgs e)
        {
            string quary = "SELECT * FROM wednesday";
            db.MySqlReturnData(quary, scheduleGW);
        }

        private void btThursday_Click(object sender, EventArgs e)
        {
            string quary = "SELECT * FROM thursday";
            db.MySqlReturnData(quary, scheduleGW);
        }

        private void btFriday_Click(object sender, EventArgs e)
        {
            string quary = "SELECT * FROM friday";
            db.MySqlReturnData(quary, scheduleGW);
        }

        private void btSaturday_Click(object sender, EventArgs e)
        {
            string quary = "SELECT * FROM saturday";
            db.MySqlReturnData(quary, scheduleGW);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string selectedTable = "";
            switch (cbDayOfWeek.SelectedIndex)
            {
                case 0:
                    selectedTable = "monday";
                    break;
                case 1:
                    selectedTable = "tuesday";
                    break;
                case 2:
                    selectedTable = "wednesday";
                    break;
                case 3:
                    selectedTable = "thursday";
                    break;
                case 4:
                    selectedTable = "friday";
                    break;
                case 5:
                    selectedTable = "saturday";
                    break;
                default:
                    MessageBox.Show("Выберите день недели.");
                    return;
            }
            
            dbconnect db = new dbconnect();
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO {selectedTable} (`groupNumb`, `time`, `subject`) VALUES(@gn, @t, @s)", db.GetConnection());

            cmd.Parameters.Add("@t", MySqlDbType.VarChar).Value = cbTime.Text;
            cmd.Parameters.Add("@gn", MySqlDbType.VarChar).Value = tbGroupNumb.Text;
            cmd.Parameters.Add("@s", MySqlDbType.VarChar).Value = tbSubject.Text;
            db.OpenConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                
                MessageBox.Show("Успешное добавление");
                tbGroupNumb.Clear();
                cbTime.Items.Clear();
                tbSubject.Clear();

            }
            else
            {
                MessageBox.Show("Произошла ошибка");
            }

            db.CloseConnection();
            
        }
       
        private void btDelete_Click(object sender, EventArgs e)
        {
            string selectedTable = "";
            switch (cbDayOfWeek.SelectedIndex)
            {
                case 0:
                    selectedTable = "monday";
                    break;
                case 1:
                    selectedTable = "tuesday";
                    break;
                case 2:
                    selectedTable = "wednesday";
                    break;
                case 3:
                    selectedTable = "thursday";
                    break;
                case 4:
                    selectedTable = "friday";
                    break;
                case 5:
                    selectedTable = "saturday";
                    break;
                default:
                    MessageBox.Show("Выберите день недели.");
                    return;
            }
            if (scheduleGW.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранные записи?", "Удаление записей", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in scheduleGW.SelectedRows)
                    {
                        string id = row.Cells["id"].Value.ToString();


                        dbconnect db = new dbconnect();
                        MySqlCommand cmd = new MySqlCommand($"DELETE FROM {selectedTable} WHERE `ID` = @id", db.GetConnection());
                        cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                        db.OpenConnection();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Запись удалена успешно");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при удалении записи");
                        }
                        db.CloseConnection();
                    }


                  
                }
            }
            else
            {
                MessageBox.Show("Выберите записи для удаления");
            }
        }

        private void btSaturday_MouseDown(object sender, MouseEventArgs e)
        {
            cbDayOfWeek.Text = "saturday";
        }

        private void btFriday_MouseDown(object sender, MouseEventArgs e)
        {
            cbDayOfWeek.Text = "friday";
        }

        private void btThursday_MouseDown(object sender, MouseEventArgs e)
        {
            cbDayOfWeek.Text = "thursday";
        }

        private void btWednesday_MouseDown(object sender, MouseEventArgs e)
        {
            cbDayOfWeek.Text = "wednesday";
        }

        private void btTuesday_MouseDown(object sender, MouseEventArgs e)
        {
            cbDayOfWeek.Text = "tuesday";
        }

        private void btMonday_MouseDown(object sender, MouseEventArgs e)
        {
            cbDayOfWeek.Text = "monday";
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (scheduleGW.SelectedRows.Count > 0)
            {
                DataGridViewRow row = scheduleGW.SelectedRows[0];

                string id = row.Cells["id"].Value.ToString();

                string grpnumb = row.Cells["groupNumb"].Value.ToString();
                string time = row.Cells["time"].Value.ToString();
                string subj = row.Cells["subject"].Value.ToString();
                string selectedTable = "";
                switch (cbDayOfWeek.SelectedIndex)
                {
                    case 0:
                        selectedTable = "monday";
                        break;
                    case 1:
                        selectedTable = "tuesday";
                        break;
                    case 2:
                        selectedTable = "wednesday";
                        break;
                    case 3:
                        selectedTable = "thursday";
                        break;
                    case 4:
                        selectedTable = "friday";
                        break;
                    case 5:
                        selectedTable = "saturday";
                        break;
                    default:
                        MessageBox.Show("Выберите день недели.");
                        return;
                }

                dbconnect db = new dbconnect();
                MySqlCommand cmd = new MySqlCommand($"UPDATE {selectedTable} SET `time` = @t, `subject` = @s, `groupNumb` = @gn WHERE `ID` = @id", db.GetConnection());

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@t", MySqlDbType.VarChar).Value = time;
                cmd.Parameters.Add("@s", MySqlDbType.VarChar).Value = subj;
                cmd.Parameters.Add("@gn", MySqlDbType.VarChar).Value = grpnumb;
                

                db.OpenConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные обновлены");
                }
                else
                {
                    MessageBox.Show("Вы не можете редактировать id");
                }
                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("Выберите строку для обновления");
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenuForm admMenu = new AdminMenuForm();
            admMenu.Show();
        }
    }
}
