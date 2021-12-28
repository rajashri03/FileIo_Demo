using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    while(!sr.EndOfStream)
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
    }
}
