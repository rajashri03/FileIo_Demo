using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace FileIO
{
    [Serializable]//indicates that this class can be serialized
    public class Contacts
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Pincode { get; set; }
    }
    class FileIOOperations
    {
        public static List<Contacts> add = new List<Contacts>();
      
        public static void CreateCsvFile()
        {
            Console.WriteLine("Enter Firstname");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zipcode");
            string zipcode = Console.ReadLine();
            Console.WriteLine("Enter Pincode");
            string pincode = Console.ReadLine();
            add.Add(new Contacts()
            {
                Firstname = fname,
                Lastname = lname,
                Address = address,
                City = city,
                State = state,
                Zipcode = zipcode,
                Pincode = pincode
            });
            string exportFilePath = @"D:\RFP146\FileIO\Contacts.csv";
            //Writingsd
            using (StreamWriter writer = new StreamWriter(exportFilePath))
            using (CsvWriter csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(add);
            }
            Console.WriteLine($"Created a CSV file at {exportFilePath}");
        }
        public static void ReadDataUsingCSV()
        {
            try
            {
                string Filepath = @"D:\RFP146\FileIO\Contacts.csv";

                using (CsvReader sw = new CsvReader(new StreamReader(Filepath), CultureInfo.InvariantCulture))
                {
                    var Record = sw.GetRecords<Contacts>();
                    foreach (var data in Record)
                    {
                        Console.WriteLine("*********Addressbook**********");
                        Console.WriteLine(data.Firstname);
                        Console.WriteLine(data.Lastname);
                        Console.WriteLine(data.Address);
                        Console.WriteLine(data.City);
                        Console.WriteLine(data.State);
                        Console.WriteLine(data.Zipcode);
                        Console.WriteLine(data.Pincode);
                        Console.WriteLine("\n");
                    }
                }
            }
            catch (FileNotFoundException f)
            {
                new Exception(f.FileName);
            }
        }
    }
}
