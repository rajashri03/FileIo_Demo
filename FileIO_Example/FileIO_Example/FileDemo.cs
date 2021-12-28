using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO_Example
{
    public class FileDemo
    {
        //File Path
        const string FilePath = @"D:\Bridgelab\FileIo_Demo\FileIO_Example\FileIO_Example\data.txt";
        /// <summary>
        /// check file is exist or not and  read data from file
        /// </summary>
        public static void ReadData()
        {
            if(File.Exists(FilePath))
            {
                var data = File.ReadAllText(FilePath);
                Console.WriteLine(data);
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            else
            {
                Console.WriteLine("File is not exist");
            }
        }
        /// <summary>
        /// Read data using StreanReader class
        /// </summary>
        public static void ReadDataUsingStreamReader()
        {
            if (File.Exists(FilePath))
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            else
            {
                Console.WriteLine("File is not exist");
            }
        }
        /// <summary>
        /// Overwrite the existing data
        /// </summary>
        /// <param name="newline"></param>
        public static void OverWriteData(string newline="")
        {
            File.WriteAllText(FilePath, newline);
            using (StreamReader sr = new StreamReader(FilePath))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
    }
}
