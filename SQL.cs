using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Backup_Maker_GUI
{
    public  class SQL
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\projects\C#\Backup_Maker_GUI\mainDB.mdf;Integrated Security=True");
        public  DataTable dt = new DataTable();
    private void Run_query(string query)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            //cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            dt.Rows.Clear();
            adapter.Fill(dt);
            con.Close();
        }

        public void Delete_entry(string id)
        {
            string query = @"DELETE FROM Folder WHERE ([Id] = '" + id + "'  )";
            Run_query(query);
            MessageBox.Show("Deleted Entry!");
        }
            public void Add_To_Database(string from, string to)
        {
            string query = @"INSERT INTO Folder VALUES('" + from + "','" + to + "')";
            Run_query(query);
            MessageBox.Show("Added folder to backup!");
        }
        public bool check_if_entry_exist(string source,string dest)
        {
            string query = "SELECT * FROM Folder WHERE ([source_folder] = '" + source + "' AND [dest_folder] = '" + dest + "'  )";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query; 
            var UserExist = cmd.ExecuteScalar();
            con.Close();
            if (UserExist == null)
            {
                //new record
                return false;
            }
            else
            {
                //same source desination exists
                return true;
            }
        }


        public void Show_From_Database()
        {
            //TODO:add code to show from db
            string query = "select * from Folder";
            Run_query(query);
        }
        public DataTable get_data()
        {
            return dt;
        }
    }
}
