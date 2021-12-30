using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicLogger;

namespace Backup_Maker_GUI
{
    class Compress
    {
        Logger log;
        string source, zip_name, destination, LogFileName = "output.txt";
        public Compress(string folder)
        {
            zip_name = "\\" + folder + ".zip";
        }
        public void start()        
        {
            string temp = "";
            SQL sql = new SQL();
            sql.Show_From_Database();
            var data = sql.get_data();
            foreach (DataRow row in data.Rows)
            {
                source = row["source_folder"].ToString();
                destination = row["dest_folder"].ToString();
                temp = "Creating zip fi;e...";
                //log.Information(temp);
                Console.WriteLine(temp);
                // Create FileStream for output ZIP archive
                using (FileStream zipFile = File.Open(destination + zip_name, FileMode.Create))
                {
                    using (Archive archive = new Archive())
                    {
                        // Folder to be Zipped
                        DirectoryInfo corpus = new DirectoryInfo(source);
                        archive.CreateEntries(corpus);
                        // Create ZIP archive
                        archive.Save(zipFile);
                    }
                }

            }

            temp = "Done creating zip fi;e...";
            //log.Information(temp);
            Console.WriteLine(temp);
        }
    }
}
