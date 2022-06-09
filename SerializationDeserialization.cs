using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace FileIO
{
    //Serialization
    //Serialization is used to export application data into a file
    //binary
    //JSON
    //XML
    //serialization is process of converting an object into stream of bytes to
    //store the objext or tansmit it to memory
    //converting an object to a binary format which is not in human readable format 
    //converting back the binary format is called deserialization
    //telephone
  
    [Serializable]
    public class contact
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class SerializationDeserialization
    {
        const string path = @"D:\RFP146\FileIO\binaryserilazation.txt";
        public static void Serializedata()
        {
            List<contact> data = new List<contact>()
            {
                new contact{Age=25,Name="Rajashri"},
                new contact{Age=24,Name="Sayali"},
                new contact{Age=22,Name="Aditi"},
            };
            FileStream stream = new FileStream(path, FileMode.Create);
            BinaryFormatter bn = new BinaryFormatter();
            bn.Serialize(stream,data);
            stream.Close();
            Console.WriteLine("Convert object to binary");
            string text = File.ReadAllText(path);
            Console.WriteLine(text);

        }
        public static void Desserialize()
        {
            FileStream strem = new FileStream(path, FileMode.Open);
            BinaryFormatter bn = new BinaryFormatter();
            var data = (List<contact>)bn.Deserialize(strem);
            strem.Close();
            Console.WriteLine("convert list of binary data to object");
            foreach(var contact in data)
            {
                Console.WriteLine(contact.Name + " " + contact.Age);
            }
        }

        public static void xmlserialization()
        {
            string path = @"D:\RFP146\FileIO\xmldata.xml";
            FileStream strem = new FileStream(path, FileMode.Create);
            XmlSerializer serialization = new XmlSerializer(typeof(List<contact>));
            List<contact> data = new List<contact>()
            {
                new contact {Age = 25, Name = "j" },
                new contact {Age = 24, Name = "Sayali" },
                new contact {Age = 23, Name = "Aditi" },
            };
            serialization.Serialize(strem, data);
        }
        public static void xmlde()
        {
            string FilePath_xmlSerializeddata = @"D:\RFP146\FileIO\xmldata.xml";
            FileStream streamdata = new FileStream(FilePath_xmlSerializeddata, FileMode.Open);
            XmlSerializer serialization = new XmlSerializer(typeof(List<contact>));
            List<contact> data = (List<contact>)serialization.Deserialize(streamdata);

            streamdata.Close();
            foreach (var d in data)
            {
                Console.WriteLine(d.Age);
                Console.WriteLine(d.Name);
            }
        }
    }
}
