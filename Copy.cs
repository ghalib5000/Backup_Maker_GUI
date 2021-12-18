using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup_Maker_GUI
{
    internal class Copy
    {
        public Copy()
        {

        }




        /*
        public ValueTask ExecuteAsync(IConsole console)
        {
            using (var fileManager = new FileManager(filename))
            {
                foreach (var file in fileManager.GetValues())
                {
                    if (!File.Exists(file.Key))
                    {
                        CopyFolder.Copy(file.Key, file.Value, "out", overwrite);
                    }
                    else
                    {
                        CopyFolder.Copyto(file.Key, file.Value, "out", overwrite);
                    }
                }

                Console.WriteLine("overwrite is: " + overwrite);
                return default;
            }
        }
    }

    //backupmaker.exe startall
    [Command("start all")]
    public class CopyAllCommand : ICommand
    {

        [CommandOption("overwrite", 'o', Description = "Name of the file.")]
        public bool overwrite { get; set; }
        public ValueTask ExecuteAsync(IConsole console)
        {
            DirectoryInfo currentPath = new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\files\\");

            foreach (FileInfo fi in currentPath.GetFiles())
            {
                using (var fileManager = new FileManager(fi.Name))
                {
                    foreach (var file in fileManager.GetValues())
                    {
                        if (!File.Exists(file.Key))
                        {
                            CopyFolder.Copy(file.Key, file.Value, "out", overwrite);
                        }
                        else
                        {
                            CopyFolder.Copyto(file.Key, file.Value, "out", overwrite);
                        }
                    }

                    Console.WriteLine("overwrite is: " + overwrite);

                }
            }
            return default;
        }
    }
    */






}
}
