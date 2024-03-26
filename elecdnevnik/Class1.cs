using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elecdnevnik
{
    internal class GridView

    {
        public string Stringmy = @"server=localhost;port=3306;username=root;password=root;database=elecdnev";
        public DataTable MySqlReturnData(string quary, DataGridView grid)
        {
            try
            {
                using (MySqlConnection myCon = new MySqlConnection(Stringmy))
                {
                    myCon.Open();
                    if (myCon.State != ConnectionState.Open)
                    {
                        return null;
                    }
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(quary, myCon))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        grid.DataSource = dt;
                        return dt;
                    }
                }
            }
            catch (MySqlException ex) 
            { return null; }
        }
    }
}
