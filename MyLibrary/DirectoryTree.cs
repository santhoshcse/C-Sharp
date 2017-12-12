using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace MyLibrary
{
    public class DirectoryTree
    {
        /// <summary>
        /// Pass the Current Path to print the Folders and Files Recursively
        /// </summary>
        /// <param name="path"></param>
        public void getDirectoryTree(string path)
        {
            String s = Path.GetFileName(path);
            Console.WriteLine(s);
            printDirectory(path, 1);
        }
        private void printDirectory(string dir, int count)
        {
            try
            {
                foreach (string file in Directory.GetFiles(dir))
                {
                    for (int i=0; i<count; i++)
                    {
                        Console.Write("    ");
                    }
                    string filename = Path.GetFileName(file);
                    Console.WriteLine("|___" + filename);
                }
                foreach (string dir1 in Directory.GetDirectories(dir))
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("    ");
                    }
                    string dirname = Path.GetFileName(dir1);
                    Console.WriteLine("|___" + dirname);
                    printDirectory(dir1, count+1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
