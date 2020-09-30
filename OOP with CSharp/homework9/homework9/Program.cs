using System;
using System.IO;

namespace homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = "data.csv";
            string outputPath = "fifa-tab.tsv";
            string contents = File.ReadAllText(inputPath);
            contents = contents.Replace(",", "\t");
            File.WriteAllText(outputPath, contents);
            Console.WriteLine("File conversion complete");
        }
    }
}
