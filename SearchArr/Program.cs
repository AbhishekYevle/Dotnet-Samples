using System;
using System.Text;
using System.Threading.Tasks;

namespace SearchArr
{
    class search
    {
        static void Main(string[] args)
        {
           Console.WriteLine("How many names you want to insert?");
           int num = Convert.ToInt32(Console.ReadLine());
           
           string[] names = new string[num];

           for(int i = 0; i < num; i++)
           {
                Console.WriteLine("Enter Data on " + i);
                string data = Console.ReadLine();
                names[i] = data;
                
           }

           Console.WriteLine("----------------Your Data----------------");

           foreach (string item in names)
           {
                Console.WriteLine(item);
           }
            
            try
            {
               
                Console.WriteLine("Search Element:");
                var stringToFind = Console.ReadLine();
                var result = Array.Find(names, elements => elements.Contains(stringToFind));
                Console.WriteLine(result);
            }
            catch(genericException)
            {
            }
            
           
        }

    }
}