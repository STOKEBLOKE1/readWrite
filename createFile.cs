using System;
using System.IO;

namespace readWrite
{
    public class createFile
    {
        public createFile(string name1, string name2)
        {
            this.Name1 = name1;
            this.Name2 = name2;
        }

        public void NewFileCreationFromValuesPassed()
        {            
            string name = "test.txt";
            string Format = "{0:yyyy-MM-dd-hh-mm-ss}_{1}";
            string filename = String.Format(Format, DateTime.Now, name);
            string directory = @"C:\Users\theb0\readWrite\";
            string path = Path.Combine(directory, filename);

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(Name1 + "," + Name2);
                    System.Console.WriteLine("File created successfully");
                    
                }
            }
        }

        public string Name1 { get; set; }
        public string Name2 { get; set; }
    }
}