using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    //streamwriter class can be ussed to write text files
    class StreamReaderWriter
    {

        public void streamReader()
        {
            string path = @"D:\RFP146\FileIO\streamwrite.txt";
            using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine("Rajashri");
                    writer.WriteLine("Rajashri1");
                    writer.WriteLine("Rajashri2");
                }
                //Console.WriteLine("File creted");
            }

            StreamWriter sw = new StreamWriter(@"D:\RFP146\FileIO\streamwrite1.txt");
            Console.WriteLine("enter text");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Close();

            StreamReader sr = new StreamReader(@"D:\RFP146\FileIO\streamwrite1.txt");
            Console.WriteLine("Content of the file");
            string str1 = sr.ReadLine();
            while (str1 != null)
            {
                Console.WriteLine(str1);
                str1 = sr.ReadLine();
            }
            sr.Close();
        }


    }
    //streamwrite.write() method is responsible for writin data into stream
}
