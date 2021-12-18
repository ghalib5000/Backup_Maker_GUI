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

            Form1 form1 = new Form1();
            form1.Show(this);
            this.Close();
        }

        private void adddata_Load(object sender, EventArgs e)
        {

        }

        private void add_folder_Click(object sender, EventArgs e)
        {
            if( source_folder.Text=="" && dest_folder.Text=="")
            {
                hidden.Text = "please enter source and destination locaitions";
            }
            else
            {
                SQL sql = new SQL();
                sql.Add_To_Database(source_folder.Text,dest_folder.Text);
            }
        }

        private void dest_folder_DoubleClick(object sender, EventArgs e)
        { 
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowDialog();
            try
            {
                dest_folder.Text = folderDlg.SelectedPath;
            }
            catch (Exception ex)
            {
                hidden.Text = ex.Message;
            }
        }

        private void source_folder_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowDialog();
            try
            {
                source_folder.Text = folderDlg.SelectedPath;
            }
            catch (Exception ex)
            {
                hidden.Text =ex.Message;
            }
        }
    }
}
