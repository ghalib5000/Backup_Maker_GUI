using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_Maker_GUI
{
    public partial class showdata : Form
    {
        SQL sql;
        public showdata()
        {
            InitializeComponent();

             sql = new SQL();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showdata_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.CurrentCell.Value;
            int output;
            bool check_if_number = int.TryParse(id.ToString(),out output);
            if (check_if_number)
            {
                sql.Delete_entry(output.ToString());
                load_data();
            }
            else
            {
                MessageBox.Show("Please select an id to remove!!!");
            }
        }
        private void load_data()
        {

            sql.Show_From_Database();
            //dataGridView1.DataSource = null;
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = sql.get_data();
            //dataGridView1.Refresh();
        }

    }
}
