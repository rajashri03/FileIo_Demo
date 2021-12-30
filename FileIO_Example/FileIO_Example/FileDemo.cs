using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace FileIO_Example
{
    [Serializable]
    //POCO Model
    public class Contact
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class FileDemo
    {
        //File Path
        const string FilePath = @"D:\Bridgelab\FileIo_Demo\FileIO_Example\FileIO_Example\data.txt";
        const string FilePath_Serializeddata = @"D:\Bridgelab\FileIo_Demo\FileIO_Example\FileIO_Example\serializeddata.txt";
        const string FilePath_XmlSerializeddata = @"D:\Bridgelab\FileIo_Demo\FileIO_Example\FileIO_Example\xmlserializeddata.txt";
        /// <summary>
        /// Serialization-object to binary
        /// </summary>
        public static void BinarySerialization()
        {
            List<Contact> data = new List<Contact>() 
            { 
                new Contact {Age = 25, Name = "Rajashri" },
                new Contact {Age = 24, Name = "Sayali" },
                new Contact {Age = 23, Name = "Aditi" },
            };
            FileStream streamdata = new FileStream(FilePath_Serializeddata, FileMode.Create);
            BinaryFormatter bn = new BinaryFormatter();
            bn.Serialize(streamdata,data);
            streamdata.Close();
            streamdata.Dispose();
            Console.WriteLine("*** Convert Object To Binary ***");
            string binaryTxt = File.ReadAllText(FilePath_Serializeddata);
            Console.WriteLine(binaryTxt);
            Console.WriteLine("\n=====================================================\n");
        }
        /// <summary>
        /// Deserialization -binary to object
        /// </summary>
        public static void BinaryDeserialization()
        {
            FileStream streamdata = new FileStream(FilePath_Serializeddata, FileMode.Open);
            BinaryFormatter bn = new BinaryFormatter();
            List<Contact> data = (List<Contact>)bn.Deserialize(streamdata);
            streamdata.Close();
            Console.WriteLine("*** Convert List Of Binary Data To Object***");
            foreach (var contact in data)
            {
                Console.WriteLine(contact.Name);
                Console.WriteLine(contact.Age);
            }
            Console.WriteLine("\n=====================================================\n");
        }
        /// <summary>
        /// check file is exist or not and  read data from file
        /// </summary>
        public static void ReadData()
        {
            if (File.Exists(FilePath))
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
        public static void AppendData(string newline = "", bool append = true)
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
