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
        const string FilePath = @"D:\Bridgelab\FileIO_Example\FileIO_Example\data.txt";
        public static void ReadData()
        {
            if(File.Exists(FilePath))
            {
                Console.WriteLine("File is exist");
            }
            else
            {
                Console.WriteLine("File is not exist");
            }
        }
    }
}
