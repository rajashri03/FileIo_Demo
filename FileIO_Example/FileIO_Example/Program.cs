// See https://aka.ms/new-console-template for more information
using FileIO_Example;

bool status = true;

while(status)
{
    Console.WriteLine("Select\n1)Check File is exits or not And read data\n2)Using StreamReader");
    int op = Convert.ToInt32(Console.ReadLine());
    switch(op)
    {
        case 1:
            FileDemo.ReadData();
            break;
        case 2:
            FileDemo.ReadDataUsingStreamReader();
            break;
        default:
            status = !status;
            break;
    }
}