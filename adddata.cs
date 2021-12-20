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
    public partial class adddata : Form
    {

        public adddata()
        {
            InitializeComponent();
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adddata_Load(object sender, EventArgs e)
        {
           
        }

        private void add_folder_Click(object sender, EventArgs e)
        {
            if( source_location.Text=="" && dest_location.Text=="")
            {
                hidden.Text = "please enter source and destination locaitions";
            }
            else
            {
                SQL sql = new SQL();
                bool check = sql.check_if_entry_exist(source_location.Text,dest_location.Text);
                if (!check)
                {
                    sql.Add_To_Database(source_location.Text, dest_location.Text);
                }
                else
                {
                    MessageBox.Show("The same entries are alredy added to the DB");
                }
            }
        }

        private void src_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if(folder.ShowDialog()==DialogResult.OK)
            {
                source_location.Text = folder.SelectedPath;

            }
        }

        private void dest_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                dest_location.Text = folder.SelectedPath;

            }
        }
    }
}
