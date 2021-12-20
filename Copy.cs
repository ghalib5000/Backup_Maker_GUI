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
        string source, destination, LogFileName="output.txt";
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
                CopyAll(source, destination, LogFileName, true);
            }
            return;
        }

        private  void CopyAll(string source, string dest, string LogFileName, bool overwrite)
        {
            DirectoryInfo source_directory = new DirectoryInfo(source);
            DirectoryInfo dest_directory = new DirectoryInfo(dest);
            if (!Directory.Exists(logloc))
                Directory.CreateDirectory(logloc);

            if (!Directory.Exists(dest_directory.FullName))
                Directory.CreateDirectory(dest_directory.FullName);

            if (log == null)
                log = new Logger(logloc ,LogFileName, date.ToString());
            // Copy each file into the new directory.
            foreach (FileInfo fi in source_directory.GetFiles())
            {
                CopyFile(dest_directory.FullName, fi, overwrite);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source_directory.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = dest_directory.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(source_directory+"\\"+diSourceSubDir.ToString(), nextTargetSubDir.ToString(), LogFileName, overwrite);
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
                temp = "Copying " + target + " to " + fi.Name;
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

