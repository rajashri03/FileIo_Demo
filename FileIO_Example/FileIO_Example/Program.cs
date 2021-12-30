// See https://aka.ms/new-console-template for more information
using FileIO_Example;

bool status = true;

while(status)
{
    Console.WriteLine("Select\n1)Check File is exits or not And read data\n2)Using StreamReader\n3)OverWriteData\n" +
        "4)AppendData\n5)Serialization and Deserialization using binary format\n6)Serialization and Deserialization using XML format");
    int op = Convert.ToInt32(Console.ReadLine());
    switch(op)
    {
        case 1:
            FileDemo.ReadData();
            break;
        case 2:
            FileDemo.ReadDataUsingStreamReader();
            break;
        case 3:
            Console.WriteLine("Enter Data");
            string data = Console.ReadLine();
            Console.WriteLine($"Added - {data} ");
            FileDemo.OverWriteData(data);
            break;
        case 4:
            Console.WriteLine("Enter Data");
            string data1 = Console.ReadLine();
            Console.WriteLine($"Added - {data1} ");
            FileDemo.AppendData(data1,true);
            break;
        case 5:
            Console.WriteLine("1)Serialization\n2)Deserialization");
            int op2= Convert.ToInt32(Console.ReadLine());
            switch(op2)
            {
                case 1:
                    FileDemo.BinarySerialization();
                    Console.WriteLine("Your Data is serialized in binary format");
                    break;
                case 2:
                    FileDemo.BinaryDeserialization();
                    Console.WriteLine("Your Data is Deserialized");
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
            break;
        case 6:
            Console.WriteLine("1)Serialization\n2)Deserialization");
            int op3 = Convert.ToInt32(Console.ReadLine());
            switch (op3)
            {
                case 1:
                    FileDemo.XmlSerialization();
                    Console.WriteLine("Your Data is serialized in XML format");
                    break;
                case 2:
                    FileDemo.XmlDeserialization();
                    Console.WriteLine("Your Data is Deserialized");
                    break;
                default:
                    Console.WriteLine("invalid option");
                    break;
            }
            break;
        default:
            status = !status;
            break;
    }
}