using BasicLogger;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_Maker_GUI
{
    internal class Copy
    {
        static Logger log;
        
        static string logloc =Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\GUI Backup Maker";
        static DateTime date = DateTime.Now;
        string source, destination, LogFileName="log.txt";
        ListBox listBox1;
        public Copy(ListBox listBox1)
        {
            this.listBox1 = listBox1;
        }

        public void Start()
        {
            SQL sql = new SQL();
            sql.Show_From_Database();
            var data = sql.get_data();
            foreach (DataRow row in data.Rows)
            {
                source = row["source_folder"].ToString();
                destination = row["dest_folder"].ToString();
                var diSource = new DirectoryInfo(source);
                var diTarget = new DirectoryInfo(destination);
                if (log == null)
                    log = new Logger(logloc, LogFileName, date.ToString());
                CopyAll(diSource, diTarget, LogFileName, true);
                var folder_name = diSource.Name;
                Compress cp = new Compress();
                cp.start(folder_name, source, destination);
                string temp = "     Copying Finished!";
                log.Information(temp);
                Console.WriteLine(temp);
                listBox1.Items.Add(temp);

                DialogResult dialogResult = MessageBox.Show( "Copied a folder, start the next one?","Success!", MessageBoxButtons.YesNo);               if (dialogResult == DialogResult.No)
                {
                    break;
                }
            }
            return;
        }

        private  void CopyAll(DirectoryInfo source, DirectoryInfo dest, string LogFileName, bool overwrite)
        {
            if (!Directory.Exists(logloc))
                Directory.CreateDirectory(logloc);

            if (!Directory.Exists(dest.FullName))
                Directory.CreateDirectory(dest.FullName);
            // Copy each file into the new directory.
            try
            {
                foreach (FileInfo fi in source.GetFiles())
                {
                    CopyFile(dest.FullName, fi, overwrite);
                }

                // Copy each subdirectory using recursion.
                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir = dest.CreateSubdirectory(diSourceSubDir.Name);
                    CopyAll(diSourceSubDir, nextTargetSubDir, LogFileName, overwrite);

                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }

        }
       
        private  void CopyFile(string target, FileInfo fi, bool overwrite)
        {
            string temp;
            if (File.Exists(target + "\\" + fi.Name))
            {
                if (!overwrite)
                {
                    temp = "The file " + fi.Name + " already Exsists";
                    log.Information(temp);
                    Console.WriteLine(temp);
                    listBox1.Items.Add(temp);
                }
                else
                {
                    temp = "Copying " + fi.Name + " to " + target;
                    log.Information(temp);
                    Console.WriteLine(temp);
                    listBox1.Items.Add(temp);
                    fi.CopyTo(Path.Combine(target, fi.Name), overwrite);
                    temp = "DONE! Overwritten " + fi.Name + " to " + target;
                    log.Information(temp);
                    Console.WriteLine(temp);
                    listBox1.Items.Add(temp);
                }
            }
            else
            {
                temp = "Copying " + fi.Name + " to " + target;
                log.Information(temp);
                Console.WriteLine(temp);
                listBox1.Items.Add(temp);
                fi.CopyTo(Path.Combine(target, fi.Name));
                temp = "DONE! Copied " + fi.Name + " to " + target;
                log.Information(temp);
                Console.WriteLine(temp);
                listBox1.Items.Add(temp);
            }
        }
    }
}

