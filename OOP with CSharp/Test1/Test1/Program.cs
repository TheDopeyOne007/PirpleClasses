using System;
using System.Collections.Generic;
using System.IO;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "testText.txt";
            string path2 = "testText2.txt";
            if(File.Exists(path))
            {
                File.Delete(path);
            }
            File.WriteAllText(path, "Hello");
            File.WriteAllLines(path2, new string[] { "Hello World!" });
            File.AppendAllText(path, "How's it going?");
            string contents = File.ReadAllText(path2);
            Console.WriteLine(contents);
            Console.WriteLine(File.ReadAllText(path));

            string newpath = "newDirectory";
            // Cannot exist already
            if(Directory.Exists(newpath))
            {
                // Deleting existing directory
                // If it is empty
                //Directory.Delete(newpath);
                Directory.Delete(newpath, true);
            }
            Directory.CreateDirectory(newpath);

            // Path Class
            // allows us to make changes to the string path that lead to directories or files
            string newerPath = "newDirectory/ourtext.txt";
            File.WriteAllText(newerPath, "This is really cool!");

            // gets directory name
            string dirName = Path.GetDirectoryName(newerPath);
            Console.WriteLine("Directory Name: " + dirName);

            // gets file extension
            string fileExt = Path.GetExtension(newerPath);
            Console.WriteLine("File extension: " + fileExt);

            // gets file name
            string fileName = Path.GetFileName(newerPath);
            Console.WriteLine("File name: " + fileName);

            // gets file name without extension
            string file_noExt = Path.GetFileNameWithoutExtension(newerPath);
            Console.WriteLine("File without ext.: " + file_noExt);

            // gets file root directory
            string root = Path.GetPathRoot(newerPath);
            Console.WriteLine("Root Directory: " + root);

            // change file extension
            string newFileRes = Path.ChangeExtension(newerPath, ".new");
            Console.WriteLine("New File Extension: " + newFileRes);

            Console.ReadKey();
        }
    }
}
