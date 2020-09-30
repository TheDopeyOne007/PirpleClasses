using System;
using System.IO;

namespace homework10
{
    class Program
    {
        // This function is the same as before, it converts a file to TSV
        static void convertToTSV(string inFileName, string outputFileName)
        {
            string contents = File.ReadAllText(inFileName);
            contents = contents.Replace(",", "\t");
            File.WriteAllText(outputFileName, contents);
            Console.WriteLine("\nFile conversion complete");
        }

        // This function displays a message depending if the program was not found or it has found it and its finished
        static void displayFinalMessage(bool found) 
        {
            Console.WriteLine("");
            if (!found)
            {
                Console.WriteLine("File couldn't be found");
            }
            else
            {
                Console.WriteLine("Program finished...");
            }
        }

        static void Main(string[] args)
        {
            // This is the name of the file without extension
            string inputFileName = "data";
            // This is the name of the file with extension
            string inputPath = "data.csv";
            // This will always be the output path for the program
            string outputPath = "fifa-tab.tsv";
            // We get the name of the current directory...
            var currDirectory = Directory.GetCurrentDirectory();
            // ...then we get all the files in that directory
            string[] filePaths = Directory.GetFiles(currDirectory);
            // A bool variable to tell us if it is found or not
            bool found = false;

            // I could also just check if the file exist or not ahead and only convert if it exist
            //if(File.Exists(inputPath))
            //{
            //    convertToTSV(inputPath, outputPath);
            //    found = true;
            //} 

            // For this approach, I want to get all the files in the current directory and check if the inputFileName is present and
            // if its extension is .csv, however, I want to give the users the opportunity to convert a file that has the same filename but different file
            // extension to .csv. Ex. "data.dat", it has the name "data" but its extension is ".dat" so I want to give the change to convert that
            // to ".csv" and then to ".tsv".
            foreach (string file in filePaths)
            {
                // If the path matches the filename and extension then it does the usual
                if(Path.GetFileNameWithoutExtension(file) == inputFileName && Path.GetExtension(file) == ".csv")
                {
                    // File not found exception is thrown due to the due change of extension in the input path
                    // So I will handle that error by first checking ahead if the file exist and that it should end with .csv
                    convertToTSV(file, outputPath);
                    found = true;
                    break;
                }
                // If the path has the same filename but extension is different then we can convert it ".csv" if the user wishes
                else if(Path.GetFileNameWithoutExtension(file) == inputFileName)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Found file {0}, do you wish to change this extension to .csv? (Y)es or press anay other key to continue.", file);
                    char choiceUser = Console.ReadKey().KeyChar;
                    if(choiceUser == 'Y' || choiceUser == 'y')
                    {
                        string newFileCSV = file;
                        newFileCSV = Path.ChangeExtension(file, ".csv");
                        File.Move(file, Path.ChangeExtension(file, ".csv"));
                        convertToTSV(newFileCSV, outputPath);
                        found = true;
                        break;
                    }
                }
            }
            displayFinalMessage(found);
            // This should prevent the file does not exist exception
        }
    }
}
