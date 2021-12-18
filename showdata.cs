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
        public showdata()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(this);
            this.Close();
        }

        private void showdata_Load(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            sql.Show_From_Database();
            dataGridView1.DataSource = sql.get_data();
        }
    }
}
