using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace elecdnevnik
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;Connect Timeout=30");


        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Вы хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { this.Show(); }
        }
        private void btEnter_Click(object sender, EventArgs e)
        {
            String loginuser = usernameTextBox.Text;
            String passuser = passwordTextBox.Text;
            dbconnect db = new dbconnect();
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `login`=@uL AND `pass`=@uP", db.GetConnection());
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `admin` WHERE `login`=@uL1 AND `pass`=@uP1", db.GetConnection());


            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginuser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passuser;
            command1.Parameters.Add("@uL1", MySqlDbType.VarChar).Value = loginuser;
            command1.Parameters.Add("@uP1", MySqlDbType.VarChar).Value = passuser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            adapter.SelectCommand = command1;
            adapter.Fill(table1);

            if (table.Rows.Count > 0)
            {

                MessageBox.Show("Вы вошли как студент");
                StudentForm form1 = new StudentForm();
                form1.Show();
                this.Hide();

            }
            else if (table1.Rows.Count > 0)
            {
                MessageBox.Show("Вы вошли как админ");
                AdminMenuForm admform = new AdminMenuForm();
                admform.Show();
                this.Hide();
            }
            else { MessageBox.Show("Неправильный логин или пароль"); }
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
    }
}

