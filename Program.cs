using System;
using System.IO;

namespace readWrite
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                System.Console.WriteLine("Enter two names");

                string name1 = Console.ReadLine();
                string name2 = Console.ReadLine();
                createFile newFile = new createFile(name1, name2);
                newFile.NewFileCreationFromValuesPassed();
                     
            }
            catch (IOException c)
            {
                Console.WriteLine($"The file could not be created: '{c}'");
            }


        }

    }
}
