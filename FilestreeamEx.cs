using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    //file stream class represents a file in the computer
    //used to read from,write to,open,and close files
    //filestream class used for reading and writing files in c#.
    //to manipulate file using Filestream you need to create an object of filestream class.
    //and this object has four parameters-the name of file,filemode,fileaccess,fileshare
    class FilestreeamEx
    {
     
            const string FilePath = @"D:\RFP146\FileIO\file.txt";
            /// <summary>
            /// check file is exist or not and  read data from file
            /// </summary>
            public static void ReadData()
            {
                if (File.Exists(FilePath))
                {
                    var data = File.ReadAllText(FilePath);
                    Console.WriteLine(data);
                    //using (StreamReader sr = new StreamReader(FilePath))
                    //{
                    //    while (!sr.EndOfStream)
                    //    {
                    //        Console.WriteLine(sr.ReadLine());
                    //    }
                    //}
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
            public static void OverWriteData(string newline = "")
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
        /// <summary>
        /// Append Data using AppendAllText
        /// </summary>
        /// <param name="newline"></param>
        /// <param name="append"></param>
        public static void AppendData(string newline = "")
        {
            File.AppendAllText(FilePath, newline);
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
