using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        //File is collection of data stored in disk with specific name and directory path
        //specific name--xyz.txt
       //directory path--C://Projects/xyz.txt
       //eg-notepad file- .txt files,wordfiles .doc files etc

        //when a file is opened for reading and writing it becomes a stream
        //input stream-read
        //output stream-write
        //system.IO
       
        static void Main(string[] args)
        {


           // FileIOOperations.WriteDataUsingCSV();
            FileIOOperations.ReadDataUsingCSV();
           FileIOOperations.CreateCsvFile();






            //while(true)
            //{
            //    FilestreeamEx s = new FilestreeamEx();
            //    Console.WriteLine("1 read 2 streamreader 3 overwrite 4 append");
            //    int option = Convert.ToInt32(Console.ReadLine());
            //    switch(option)
            //    {
            //        case 1:
            //            FilestreeamEx.ReadData();
            //            break;
            //        case 2:
            //            FilestreeamEx.ReadDataUsingStreamReader();
            //            break;
            //        case 3:
            //            Console.WriteLine("Enter Data");
            //            string data = Console.ReadLine();
            //            Console.WriteLine($"Added - {data} ");
            //            FilestreeamEx.OverWriteData(data);
            //            break;
            //        case 4:
            //            Console.WriteLine("Enter Data");
            //            string data1 = Console.ReadLine();
            //            Console.WriteLine($"Added - {data1} ");
            //            FilestreeamEx.AppendData(data1);
            //            break;
            //    }
            //}
            //SerializationDeserialization.Serializedata();
            //SerializationDeserialization.Desserialize();
            //SerializationDeserialization.xmlde();
           // SerializationDeserialization.xmlserialization();





            //StreamReaderWriter stream = new StreamReaderWriter();
            //stream.streamReader();


            //string line;
            //line = File.ReadAllText(path);
            //Console.WriteLine(line);
            //string[] lines;
            //lines = File.ReadAllLines(path);
            //Console.WriteLine(lines[0]);
            //Console.WriteLine(lines[1]);

            //if(File.Exists(path))
            //{
            //    Console.WriteLine("File exists");
            //}
            //else
            //{
            //    Console.WriteLine("Not");
            //}
        }
    }
}
