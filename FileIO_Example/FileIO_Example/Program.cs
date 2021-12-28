// See https://aka.ms/new-console-template for more information
using FileIO_Example;

bool status = true;

while(status)
{
    Console.WriteLine("Select\n1)Check File is exits or not And read data\n2)Using StreamReader\n3)OverWriteData\n4)AppendData");
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
        default:
            status = !status;
            break;
    }
}