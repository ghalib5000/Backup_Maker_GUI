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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

            adddata adddata = new adddata();
            adddata.ShowDialog();
        }

        private void show_all_Click(object sender, EventArgs e)
        {
            showdata showdata = new showdata();
            showdata.ShowDialog();
        }

        private void start_backup_Click(object sender, EventArgs e)
        {
            Copy copy = new Copy(listBox1);
            copy.Start();
            MessageBox.Show("Done!");
        }
    }
}
