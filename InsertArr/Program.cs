using System;
using System.Text;
using System.Threading.Tasks;

namespace InsertArr
{
    class Array
    {
        static void Main(string[] args)
        {
           Console.WriteLine("How many names you want to insert?");
           int num = Convert.ToInt32(Console.ReadLine());
           
           string[] names = new string[num];

           for(int i = 0; i < num; i++)
           {
                Console.WriteLine("Enter Data:");
                string data = Console.ReadLine();
                names[i] = data;
                
           }

           Console.WriteLine("----------------Your Data----------------");

           foreach (string item in names)
           {
                Console.WriteLine(item);
                
           }

           
        }

    }
}